// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>



#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// A drop-down list control.
    /// </summary>
    public partial class ComboBox<T> : BlazorBindings.AvaloniaBindings.Elements.Primitives.SelectingItemsControl<T>
    {
        static ComboBox()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the horizontal alignment of the content within the control.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.HorizontalAlignment? HorizontalContentAlignment { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the dropdown is currently open.
        /// </summary>
        [Parameter] public bool? IsDropDownOpen { get; set; }
        /// <summary>
        /// Gets or sets the maximum height for the dropdown list.
        /// </summary>
        [Parameter] public double? MaxDropDownHeight { get; set; }
        /// <summary>
        /// Gets or sets the Brush that renders the placeholder text.
        /// </summary>
        [Parameter] public global::Avalonia.Media.IBrush PlaceholderForeground { get; set; }
        /// <summary>
        /// Gets or sets the PlaceHolder text.
        /// </summary>
        [Parameter] public string PlaceholderText { get; set; }
        /// <summary>
        /// Gets or sets the vertical alignment of the content within the control.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.VerticalAlignment? VerticalContentAlignment { get; set; }
        [Parameter] public EventCallback OnDropDownClosed { get; set; }
        [Parameter] public EventCallback OnDropDownOpened { get; set; }

        public new AC.ComboBox NativeControl => (AC.ComboBox)((BindableObject)this).NativeControl;

        protected override AC.ComboBox CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(HorizontalContentAlignment):
                    if (!Equals(HorizontalContentAlignment, value))
                    {
                        HorizontalContentAlignment = (global::Avalonia.Layout.HorizontalAlignment?)value;
                        NativeControl.HorizontalContentAlignment = HorizontalContentAlignment ?? (global::Avalonia.Layout.HorizontalAlignment)AC.ComboBox.HorizontalContentAlignmentProperty.GetDefaultValue(AC.ComboBox.HorizontalContentAlignmentProperty.OwnerType);
                    }
                    break;
                case nameof(IsDropDownOpen):
                    if (!Equals(IsDropDownOpen, value))
                    {
                        IsDropDownOpen = (bool?)value;
                        NativeControl.IsDropDownOpen = IsDropDownOpen ?? (bool)AC.ComboBox.IsDropDownOpenProperty.GetDefaultValue(AC.ComboBox.IsDropDownOpenProperty.OwnerType);
                    }
                    break;
                case nameof(MaxDropDownHeight):
                    if (!Equals(MaxDropDownHeight, value))
                    {
                        MaxDropDownHeight = (double?)value;
                        NativeControl.MaxDropDownHeight = MaxDropDownHeight ?? (double)AC.ComboBox.MaxDropDownHeightProperty.GetDefaultValue(AC.ComboBox.MaxDropDownHeightProperty.OwnerType);
                    }
                    break;
                case nameof(PlaceholderForeground):
                    if (!Equals(PlaceholderForeground, value))
                    {
                        PlaceholderForeground = (global::Avalonia.Media.IBrush)value;
                        NativeControl.PlaceholderForeground = PlaceholderForeground;
                    }
                    break;
                case nameof(PlaceholderText):
                    if (!Equals(PlaceholderText, value))
                    {
                        PlaceholderText = (string)value;
                        NativeControl.PlaceholderText = PlaceholderText;
                    }
                    break;
                case nameof(VerticalContentAlignment):
                    if (!Equals(VerticalContentAlignment, value))
                    {
                        VerticalContentAlignment = (global::Avalonia.Layout.VerticalAlignment?)value;
                        NativeControl.VerticalContentAlignment = VerticalContentAlignment ?? (global::Avalonia.Layout.VerticalAlignment)AC.ComboBox.VerticalContentAlignmentProperty.GetDefaultValue(AC.ComboBox.VerticalContentAlignmentProperty.OwnerType);
                    }
                    break;
                case nameof(OnDropDownClosed):
                    if (!Equals(OnDropDownClosed, value))
                    {
                        void NativeControlDropDownClosed(object sender, EventArgs e) => InvokeEventCallback(OnDropDownClosed);

                        OnDropDownClosed = (EventCallback)value;
                        NativeControl.DropDownClosed -= NativeControlDropDownClosed;
                        NativeControl.DropDownClosed += NativeControlDropDownClosed;
                    }
                    break;
                case nameof(OnDropDownOpened):
                    if (!Equals(OnDropDownOpened, value))
                    {
                        void NativeControlDropDownOpened(object sender, EventArgs e) => InvokeEventCallback(OnDropDownOpened);

                        OnDropDownOpened = (EventCallback)value;
                        NativeControl.DropDownOpened -= NativeControlDropDownOpened;
                        NativeControl.DropDownOpened += NativeControlDropDownOpened;
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