// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using ACD = Avalonia.Controls.Documents;
using BlazorBindings.AvaloniaBindings.Elements;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements.Documents
{
    /// <summary>
    /// InlineUIContainer - a wrapper for embedded UIElements in text flow content inline collections
    /// </summary>
    public partial class InlineUIContainer : Inline
    {
        static InlineUIContainer()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// The content spanned by this TextElement.
        /// </summary>
        [Parameter] public AC.Control Child { get; set; }

        public new ACD.InlineUIContainer NativeControl => (ACD.InlineUIContainer)((AvaloniaObject)this).NativeControl;

        protected override ACD.InlineUIContainer CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Child):
                    if (!Equals(Child, value))
                    {
                        Child = (AC.Control)value;
                        NativeControl.Child = Child;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}