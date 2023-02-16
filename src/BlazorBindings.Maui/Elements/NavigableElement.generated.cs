// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements
{
    /// <summary>
    /// A <see cref="T:Microsoft.Maui.Controls.Element" /> that supports navigation.
    /// </summary>
    public abstract partial class NavigableElement : Element
    {
        static NavigableElement()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public string @class { get; set; }
        [Parameter] public string StyleClass { get; set; }

        public new MC.NavigableElement NativeControl => (MC.NavigableElement)((BindableObject)this).NativeControl;


        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(@class):
                    if (!Equals(@class, value))
                    {
                        @class = (string)value;
                        NativeControl.@class = AttributeHelper.GetStringList(@class);
                    }
                    break;
                case nameof(StyleClass):
                    if (!Equals(StyleClass, value))
                    {
                        StyleClass = (string)value;
                        NativeControl.StyleClass = AttributeHelper.GetStringList(StyleClass);
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
