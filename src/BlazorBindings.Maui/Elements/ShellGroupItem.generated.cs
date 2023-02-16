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
    /// A <see cref="T:Microsoft.Maui.Controls.BaseShellItem" /> that has <see cref="T:Microsoft.Maui.Controls.FlyoutDisplayOptions" />. Base class for <see cref="T:Microsoft.Maui.Controls.ShellItem" /> and <see cref="T:Microsoft.Maui.Controls.ShellSection" />.
    /// </summary>
    public partial class ShellGroupItem : BaseShellItem
    {
        static ShellGroupItem()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// AsSingleItem (default) will only display the title of this item in the flyout. AsMultipleItems will create a separate flyout option for each child and <see cref="T:Microsoft.Maui.Controls.MenuItem" />.
        /// </summary>
        [Parameter] public MC.FlyoutDisplayOptions? FlyoutDisplayOptions { get; set; }

        public new MC.ShellGroupItem NativeControl => (MC.ShellGroupItem)((BindableObject)this).NativeControl;

        protected override MC.ShellGroupItem CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(FlyoutDisplayOptions):
                    if (!Equals(FlyoutDisplayOptions, value))
                    {
                        FlyoutDisplayOptions = (MC.FlyoutDisplayOptions?)value;
                        NativeControl.FlyoutDisplayOptions = FlyoutDisplayOptions ?? (MC.FlyoutDisplayOptions)MC.ShellGroupItem.FlyoutDisplayOptionsProperty.DefaultValue;
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
