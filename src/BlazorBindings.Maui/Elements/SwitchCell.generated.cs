// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements
{
    /// <summary>
    /// A <see cref="T:Microsoft.Maui.Controls.Cell" /> with a label and an on/off switch.
    /// </summary>
    public partial class SwitchCell : Cell
    {
        static SwitchCell()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the state of the switch.
        /// </summary>
        /// <value>
        /// Default is <see langword="false" />.
        /// </value>
        [Parameter] public bool? On { get; set; }
        [Parameter] public Color OnColor { get; set; }
        /// <summary>
        /// Gets or sets the text displayed next to the switch.
        /// </summary>
        [Parameter] public string Text { get; set; }
        [Parameter] public EventCallback<bool> OnChanged { get; set; }

        public new MC.SwitchCell NativeControl => (MC.SwitchCell)((BindableObject)this).NativeControl;

        protected override MC.SwitchCell CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(On):
                    if (!Equals(On, value))
                    {
                        On = (bool?)value;
                        NativeControl.On = On ?? (bool)MC.SwitchCell.OnProperty.DefaultValue;
                    }
                    break;
                case nameof(OnColor):
                    if (!Equals(OnColor, value))
                    {
                        OnColor = (Color)value;
                        NativeControl.OnColor = OnColor;
                    }
                    break;
                case nameof(Text):
                    if (!Equals(Text, value))
                    {
                        Text = (string)value;
                        NativeControl.Text = Text;
                    }
                    break;
                case nameof(OnChanged):
                    if (!Equals(OnChanged, value))
                    {
                        void NativeControlOnChanged(object sender, MC.ToggledEventArgs e)
                        {
                            var value = NativeControl.On;
                            On = value;
                            InvokeEventCallback(OnChanged, value);
                        }

                        OnChanged = (EventCallback<bool>)value;
                        NativeControl.OnChanged -= NativeControlOnChanged;
                        NativeControl.OnChanged += NativeControlOnChanged;
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
