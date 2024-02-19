// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using System.Windows.Input;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public partial class TrayIcon : AvaloniaObject
    {
        static TrayIcon()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the <see cref="P:Avalonia.Controls.TrayIcon.Command" /> property of a TrayIcon.
        /// </summary>
        [Parameter] public ICommand Command { get; set; }
        /// <summary>
        /// Gets or sets the parameter to pass to the <see cref="P:Avalonia.Controls.TrayIcon.Command" /> property of a <see cref="T:Avalonia.Controls.TrayIcon" />.
        /// </summary>
        [Parameter] public object CommandParameter { get; set; }
        /// <summary>
        /// Gets or sets the icon of the TrayIcon.
        /// </summary>
        [Parameter] public AC.WindowIcon Icon { get; set; }
        /// <summary>
        /// Gets or sets the visibility of the TrayIcon.
        /// </summary>
        [Parameter] public bool? IsVisible { get; set; }
        /// <summary>
        /// Gets or sets the Menu of the TrayIcon.
        /// </summary>
        [Parameter] public AC.NativeMenu Menu { get; set; }
        /// <summary>
        /// Gets or sets the tooltip text of the TrayIcon.
        /// </summary>
        [Parameter] public string ToolTipText { get; set; }
        [Parameter] public EventCallback OnClick { get; set; }

        public new AC.TrayIcon NativeControl => (AC.TrayIcon)((AvaloniaObject)this).NativeControl;

        protected override AC.TrayIcon CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Command):
                    if (!Equals(Command, value))
                    {
                        Command = (ICommand)value;
                        NativeControl.Command = Command;
                    }
                    break;
                case nameof(CommandParameter):
                    if (!Equals(CommandParameter, value))
                    {
                        CommandParameter = (object)value;
                        NativeControl.CommandParameter = CommandParameter;
                    }
                    break;
                case nameof(Icon):
                    if (!Equals(Icon, value))
                    {
                        Icon = (AC.WindowIcon)value;
                        NativeControl.Icon = Icon;
                    }
                    break;
                case nameof(IsVisible):
                    if (!Equals(IsVisible, value))
                    {
                        IsVisible = (bool?)value;
                        NativeControl.IsVisible = IsVisible ?? (bool)AC.TrayIcon.IsVisibleProperty.GetDefaultValue(AC.TrayIcon.IsVisibleProperty.OwnerType);
                    }
                    break;
                case nameof(Menu):
                    if (!Equals(Menu, value))
                    {
                        Menu = (AC.NativeMenu)value;
                        NativeControl.Menu = Menu;
                    }
                    break;
                case nameof(ToolTipText):
                    if (!Equals(ToolTipText, value))
                    {
                        ToolTipText = (string)value;
                        NativeControl.ToolTipText = ToolTipText;
                    }
                    break;
                case nameof(OnClick):
                    if (!Equals(OnClick, value))
                    {
                        void NativeControlClicked(object sender, EventArgs e) => InvokeEventCallback(OnClick);

                        OnClick = (EventCallback)value;
                        NativeControl.Clicked -= NativeControlClicked;
                        NativeControl.Clicked += NativeControlClicked;
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