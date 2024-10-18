﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Avalonia.Controls.Templates;

namespace BlazorBindings.AvaloniaBindings.Elements.DataTemplates;

/// <summary>
/// Unlike <see cref="DataTemplateItemsComponent{TControl, TItem}"/>, this DataTemplate component does not use a wrapping element. 
/// This makes it possible to use when returning a View from template is not an option.
/// However, it requires a DataTemplate to render synchronously, which does not always work with Blazor.
/// </summary>
internal class SyncDataTemplateItemsComponent<TControl, TItem> : NativeControlComponentBase, IContainerElementHandler, INonPhysicalChild
{
    protected override RenderFragment GetChildContent() => builder =>
    {
        foreach (var item in _initialItems)
        {
            builder.OpenComponent<SyncDataTemplateItemComponent<TItem>>(1);
            builder.AddAttribute(2, nameof(SyncDataTemplateItemComponent<TItem>.Template), Template);
            builder.AddAttribute(3, nameof(SyncDataTemplateItemComponent<TItem>.InitialItem), item);
            builder.AddComponentReferenceCapture(4, c => _lastAddedItem = (SyncDataTemplateItemComponent<TItem>)c);
            builder.CloseComponent();
        }
    };

    [Parameter] public Action<TControl, AvaloniaDataTemplate> SetDataTemplateAction { get; set; }
    [Parameter] public RenderFragment<TItem> Template { get; set; }

    private readonly List<TItem> _initialItems = [];

    private SyncDataTemplateItemComponent<TItem> _lastAddedItem;

    public AvaloniaBindableObject AddTemplateRoot(TItem initialItem)
    {
        _initialItems.Add(initialItem);
        StateHasChanged();

        var rootElement = _lastAddedItem?.RootControl
            ?? throw new InvalidOperationException("Template root control is supposed to be rendered at this point.");
        _lastAddedItem = null;

        return rootElement;
    }

    void INonPhysicalChild.SetParent(object parentElement)
    {
        var parent = (TControl)parentElement;
        //var dataTemplate = new DataTemplateSelector(AddTemplateRoot);
        //var dataTemplate = new Avalonia.Controls.Templates.FuncTemplate<TItem, Avalonia.Controls.Panel>(
        //    (item, ns) => (global::Avalonia.Controls.Panel)AddTemplateRoot(item));
        var dataTemplate = new AC.Templates.FuncDataTemplate(typeof(TItem),
            (item, namescope) => (AC.Control)AddTemplateRoot((TItem)item));
        //SetDataTemplateAction(parent, dataTemplate);
        SetDataTemplateAction(parent, dataTemplate);
    }

    void INonPhysicalChild.RemoveFromParent(object parentElement) { }
    object IElementHandler.TargetElement => null;
    void IContainerElementHandler.AddChild(object child, int physicalSiblingIndex) { }
    void IContainerElementHandler.RemoveChild(object child, int physicalSiblingIndex) { }

    // In order to be able to render the item synchronously, we need to have an item upfront, before the render.
    // Unfortunately, regular DataTemplate does not have an access to the item, it is set set BindingContext afterwards.
    // In order to workaround this issue, we use a DataTemplateSelector, which returns the same DataTemplate. But we're able
    // to store the item from OnSelectTemplate method, which is used to render the item in DataTemplate.
    //class DataTemplateSelector : AC.DataTemplateSelector
    //{
    //    private readonly AC.DataTemplate _dataTemplate;
    //    private readonly Func<TItem, AC.BindableObject> _loadTemplate;
    //    private TItem _initialItem;

    //    public DataTemplateSelector(Func<TItem, AC.BindableObject> loadTemplate)
    //    {
    //        _loadTemplate = loadTemplate;
    //        _dataTemplate = new AC.DataTemplate(() => _loadTemplate(_initialItem));
    //    }

    //    protected override AC.DataTemplate OnSelectTemplate(object item, AC.BindableObject container)
    //    {
    //        _initialItem = (TItem)item;
    //        return _dataTemplate;
    //    }
    //}
}
