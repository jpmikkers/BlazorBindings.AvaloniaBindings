// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml.Templates;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorBindings.AvaloniaBindings.Elements.DataTemplates;

/// <summary>
/// This ControlTemplate implementation wraps the content in an additional View, therefore it is not suitable in cases when non-View content
/// is expected from template.
/// </summary>
internal class ControlTemplateItemsComponent<TControl, TTemplate> : NativeControlComponentBase, IContainerElementHandler, INonPhysicalChild
    where TControl : TemplatedControl
{
    protected override RenderFragment GetChildContent()
    {
        return builder =>
        {
            foreach (var itemRoot in _itemRoots)
            {
                builder.OpenComponent<InitializedContentView>(1);

                builder.AddAttribute(2, nameof(InitializedContentView.NativeControl), itemRoot);
                builder.AddAttribute(3, "ChildContent", (RenderFragment)(builder =>
                {
                    Template.Invoke(builder);
                }));

                builder.CloseComponent();
            }
        };
    }

    [Parameter] public Action<TControl, TTemplate> SetControlTemplateAction { get; set; }

    [Parameter] public RenderFragment Template { get; set; }


    private readonly List<AC.ContentControl> _itemRoots = [];

    private AC.ContentControl AddTemplateRoot()
    {
        var templateRoot = new AC.ContentControl();
        _itemRoots.Add(templateRoot);
        StateHasChanged();

        return templateRoot;
    }

    void INonPhysicalChild.SetParent(object parentElement)
    {
        var parent = parentElement as TControl;

        if (SetControlTemplateAction != null)
        {
            if (typeof(ITemplate<AC.Panel>).IsAssignableFrom(typeof(TTemplate)))
            {
                var controlTemplate = new ItemsPanelTemplate()
                {
                    Content = (Func<IServiceProvider, object>)((serviceProvider) => new TemplateResult<AC.Control>((AC.Control)AddTemplateRoot().Content, null))
                };
                SetControlTemplateAction(parent, (TTemplate)(object)controlTemplate);
            }
            else if (typeof(TTemplate).IsAssignableTo(typeof(IControlTemplate)))
            {
                var controlTemplate = new ControlTemplate
                {
                    Content = (Func<IServiceProvider, object>)((serviceProvider) => new TemplateResult<AC.Control>((AC.Control)AddTemplateRoot().Content, null))
                };
                SetControlTemplateAction(parent, (TTemplate)(object)controlTemplate);
            }
        }
    }


    void INonPhysicalChild.RemoveFromParent(object parentElement) { }
    void IContainerElementHandler.AddChild(object child, int physicalSiblingIndex) { }
    void IContainerElementHandler.RemoveChild(object child, int physicalSiblingIndex) { }
    object IElementHandler.TargetElement => null;
}
