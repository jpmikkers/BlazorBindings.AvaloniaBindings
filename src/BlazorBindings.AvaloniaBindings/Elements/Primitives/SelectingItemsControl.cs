namespace BlazorBindings.AvaloniaBindings.Elements.Primitives;

public partial class SelectingItemsControl<T>
{
    [Parameter] public EventCallback<T?> SelectedItemChanged { get; set; }
    [Parameter] public EventCallback<int> SelectedIndexChanged { get; set; }

    protected override bool HandleAdditionalParameter(string name, object value)
    {
        switch (name)
        {
            case nameof(SelectedItemChanged):
                void NativeControlSelectedItemChanged(object sender, AC.SelectionChangedEventArgs e)
                {
                    var value = NativeControl.SelectedItem;
                    SelectedItem = value;
                    if (value is null)
                    {
                        value = default(T);
                    }
                    InvokeEventCallback(SelectedItemChanged, (T)value);
                }

                SelectedItemChanged = (EventCallback<T>)value;
                NativeControl.SelectionChanged -= NativeControlSelectedItemChanged;
                NativeControl.SelectionChanged += NativeControlSelectedItemChanged;
                return true;

            case nameof(SelectedIndexChanged):
                void NativeControlSelectedIndexChanged(object sender, AC.SelectionChangedEventArgs e)
                {
                    var value = NativeControl?.SelectedIndex;
                    SelectedIndex = value;
                    InvokeEventCallback(SelectedIndexChanged, value ?? -1);
                }

                SelectedIndexChanged = (EventCallback<int>)value;
                NativeControl.SelectionChanged -= NativeControlSelectedIndexChanged;
                NativeControl.SelectionChanged += NativeControlSelectedIndexChanged;
                return true;
        }

        return base.HandleAdditionalParameter(name, value);
    }
}
