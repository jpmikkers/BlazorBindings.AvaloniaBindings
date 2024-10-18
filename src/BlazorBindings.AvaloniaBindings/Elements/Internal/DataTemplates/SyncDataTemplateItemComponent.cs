﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.AvaloniaBindings.Elements.Internal;
using BlazorBindings.AvaloniaBindings.Extensions;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorBindings.AvaloniaBindings.Elements.DataTemplates;

internal class SyncDataTemplateItemComponent<T> : ComponentBase
{
    private T _item;
    private bool _shouldRender = true;
    private bool _initialValueSet;

    public global::Avalonia.StyledElement RootControl { get; private set; }

    [Parameter] public RenderFragment<T> Template { get; set; }
    [Parameter] public T InitialItem { get; set; }

    public override Task SetParametersAsync(ParameterView parameters)
    {
        foreach (var parValue in parameters)
        {
            switch (parValue.Name)
            {
                case nameof(Template):
                    Template = (RenderFragment<T>)parValue.Value;
                    break;

                case nameof(InitialItem):
                    if (!_initialValueSet)
                    {
                        InitialItem = (T)parValue.Value;
                        _item = InitialItem;
                        _initialValueSet = true;
                    }
                    break;
            }
        }

        return base.SetParametersAsync(ParameterView.Empty);
    }

    protected override bool ShouldRender()
    {
        // Re-rendering is required only if BindingContext is changed.
        // If this method is not overridden, it re-renders all items in DataTemplateItemsComponent
        // when new item is added there.
        return _shouldRender;
    }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        if (_item != null)
        {
            builder.OpenComponent<RootContainerComponent>(0);
            builder.AddAttribute(1, "ChildContent", Template.Invoke(_item));
            builder.AddAttribute(2, nameof(RootContainerComponent.OnElementAdded), EventCallback.Factory.Create<object>(this, OnRootElementAdded));
            builder.CloseComponent();

            _shouldRender = false;
        }
    }

    private void OnRootElementAdded(object rootControl)
    {
        var bindableRoot = rootControl.Cast<global::Avalonia.StyledElement>();

        if (RootControl != null)
            throw new InvalidOperationException("DateTemplate cannot have more than one root element.");

        RootControl = bindableRoot;
        if (bindableRoot.DataContext != null)
        {
            _item = (T)bindableRoot.DataContext;
        }

        bindableRoot.DataContextChanged += (_, __) =>
        {
            T newItem = default;

            if (bindableRoot.DataContext is not null)
            {
                newItem = (T)bindableRoot.DataContext;
            }
            if (newItem != null && !Equals(newItem, _item))
            {
                _item = newItem;
                _shouldRender = true;
                StateHasChanged();
            }
        };
    }
}
