// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using ACS = Avalonia.Controls.Shapes;
using BlazorBindings.AvaloniaBindings.Elements;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements.Shapes
{
    public partial class Ellipse : Shape
    {
        static Ellipse()
        {
            RegisterAdditionalHandlers();
        }

        public new ACS.Ellipse NativeControl => (ACS.Ellipse)((AvaloniaObject)this).NativeControl;

        protected override ACS.Ellipse CreateNativeElement() => new();


        static partial void RegisterAdditionalHandlers();
    }
}
