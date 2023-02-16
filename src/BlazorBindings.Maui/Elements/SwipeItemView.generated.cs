// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements
{
    public partial class SwipeItemView : ContentView
    {
        static SwipeItemView()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public EventCallback OnInvoked { get; set; }

        public new MC.SwipeItemView NativeControl => (MC.SwipeItemView)((BindableObject)this).NativeControl;

        protected override MC.SwipeItemView CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(OnInvoked):
                    if (!Equals(OnInvoked, value))
                    {
                        void NativeControlInvoked(object sender, EventArgs e) => InvokeEventCallback(OnInvoked);

                        OnInvoked = (EventCallback)value;
                        NativeControl.Invoked -= NativeControlInvoked;
                        NativeControl.Invoked += NativeControlInvoked;
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
