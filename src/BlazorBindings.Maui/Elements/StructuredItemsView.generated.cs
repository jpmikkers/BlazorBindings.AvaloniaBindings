// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class StructuredItemsView<T> : ItemsView<T>
    {
        static StructuredItemsView()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<StructuredItemsView<T>>(nameof(Footer),
                (renderer, parent, component) => new DataTemplatePropertyHandler<MC.StructuredItemsView>(component,
                    (x, dataTemplate) => x.FooterTemplate = dataTemplate));
            ElementHandlerRegistry.RegisterPropertyContentHandler<StructuredItemsView<T>>(nameof(Header),
                (renderer, parent, component) => new DataTemplatePropertyHandler<MC.StructuredItemsView>(component,
                    (x, dataTemplate) => x.HeaderTemplate = dataTemplate));
            RegisterAdditionalHandlers();
        }

        [Parameter] public MC.ItemSizingStrategy? ItemSizingStrategy { get; set; }
        [Parameter] public MC.IItemsLayout ItemsLayout { get; set; }
        [Parameter] public RenderFragment Footer { get; set; }
        [Parameter] public RenderFragment Header { get; set; }

        public new MC.StructuredItemsView NativeControl => (MC.StructuredItemsView)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.StructuredItemsView();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(ItemSizingStrategy):
                    if (!Equals(ItemSizingStrategy, value))
                    {
                        ItemSizingStrategy = (MC.ItemSizingStrategy?)value;
                        NativeControl.ItemSizingStrategy = ItemSizingStrategy ?? (MC.ItemSizingStrategy)MC.StructuredItemsView.ItemSizingStrategyProperty.DefaultValue;
                    }
                    break;
                case nameof(ItemsLayout):
                    if (!Equals(ItemsLayout, value))
                    {
                        ItemsLayout = (MC.IItemsLayout)value;
                        NativeControl.ItemsLayout = ItemsLayout;
                    }
                    break;
                case nameof(Footer):
                    Footer = (RenderFragment)value;
                    break;
                case nameof(Header):
                    Header = (RenderFragment)value;
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddDataTemplateProperty(builder, sequence++, typeof(StructuredItemsView<T>), Footer);
            RenderTreeBuilderHelper.AddDataTemplateProperty(builder, sequence++, typeof(StructuredItemsView<T>), Header);
        }

        static partial void RegisterAdditionalHandlers();
    }
}