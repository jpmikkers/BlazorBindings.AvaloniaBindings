// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using ACP = Avalonia.Controls.Primitives;
using BlazorBindings.AvaloniaBindings.Elements;
using Microsoft.AspNetCore.Components.Rendering;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements.Primitives
{
    /// <summary>
    /// Represents a <see cref="T:Avalonia.Controls.Primitives.SelectingItemsControl" /> with a related header.
    /// </summary>
    public partial class HeaderedSelectingItemsControl<T> : SelectingItemsControl<T>
    {
        static HeaderedSelectingItemsControl()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the content of the control's header.
        /// </summary>
        [Parameter] public object Header { get; set; }
        /// <summary>
        /// Gets or sets the data template used to display the header content of the control.
        /// </summary>
        [Parameter] public RenderFragment HeaderTemplate { get; set; }

        public new ACP.HeaderedSelectingItemsControl NativeControl => (ACP.HeaderedSelectingItemsControl)((AvaloniaObject)this).NativeControl;

        protected override ACP.HeaderedSelectingItemsControl CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Header):
                    if (!Equals(Header, value))
                    {
                        Header = (object)value;
                        NativeControl.Header = Header;
                    }
                    break;
                case nameof(HeaderTemplate):
                    HeaderTemplate = (RenderFragment)value;
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddDataTemplateProperty<ACP.HeaderedSelectingItemsControl>(builder, sequence++, HeaderTemplate,
                (nativeControl, nativeTemplate) => nativeControl.HeaderTemplate = nativeTemplate);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
