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
    /// A control to allow the user to select a time.
    /// </summary>
    public partial class TimePicker : BlazorBindings.AvaloniaBindings.Elements.Primitives.TemplatedControl
    {
        static TimePicker()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the clock identifier, either 12HourClock or 24HourClock
        /// </summary>
        [Parameter] public string ClockIdentifier { get; set; }
        /// <summary>
        /// Gets or sets the minute increment in the picker
        /// </summary>
        [Parameter] public int? MinuteIncrement { get; set; }
        /// <summary>
        /// Gets or sets the selected time. Can be null.
        /// </summary>
        [Parameter] public Nullable<TimeSpan> SelectedTime { get; set; }
        [Parameter] public EventCallback<Nullable<TimeSpan>> SelectedTimeChanged { get; set; }

        public new AC.TimePicker NativeControl => (AC.TimePicker)((AvaloniaObject)this).NativeControl;

        protected override AC.TimePicker CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(ClockIdentifier):
                    if (!Equals(ClockIdentifier, value))
                    {
                        ClockIdentifier = (string)value;
                        NativeControl.ClockIdentifier = ClockIdentifier;
                    }
                    break;
                case nameof(MinuteIncrement):
                    if (!Equals(MinuteIncrement, value))
                    {
                        MinuteIncrement = (int?)value;
                        NativeControl.MinuteIncrement = MinuteIncrement ?? (int)AC.TimePicker.MinuteIncrementProperty.GetDefaultValue(AC.TimePicker.MinuteIncrementProperty.OwnerType);
                    }
                    break;
                case nameof(SelectedTime):
                    if (!Equals(SelectedTime, value))
                    {
                        SelectedTime = (Nullable<TimeSpan>)value;
                        NativeControl.SelectedTime = SelectedTime;
                    }
                    break;
                case nameof(SelectedTimeChanged):
                    if (!Equals(SelectedTimeChanged, value))
                    {
                        void NativeControlSelectedTimeChanged(object sender, AC.TimePickerSelectedValueChangedEventArgs e)
                        {
                            var value = NativeControl.SelectedTime;
                            SelectedTime = value;
                            InvokeEventCallback(SelectedTimeChanged, value);
                        }

                        SelectedTimeChanged = (EventCallback<Nullable<TimeSpan>>)value;
                        NativeControl.SelectedTimeChanged -= NativeControlSelectedTimeChanged;
                        NativeControl.SelectedTimeChanged += NativeControlSelectedTimeChanged;
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