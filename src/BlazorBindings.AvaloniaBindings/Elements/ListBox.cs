using System.Collections;

namespace BlazorBindings.AvaloniaBindings.Elements;

public partial class ListBox<T>
{
    [Parameter] public EventCallback<IList> SelectedItemsChanged { get; set; }

    protected override bool HandleAdditionalParameter(string name, object value)
    {
        switch (name)
        {
            case nameof(SelectedItemsChanged):
                void NativeControlSelectedItemsChanged(object sender, AC.SelectionChangedEventArgs e)
                {
                    var value = NativeControl.SelectedItems;
                    SelectedItems = value;
                    InvokeEventCallback(SelectedItemsChanged, value);
                }

                SelectedItemsChanged = (EventCallback<IList>)value;
                NativeControl.SelectionChanged -= NativeControlSelectedItemsChanged;
                NativeControl.SelectionChanged += NativeControlSelectedItemsChanged;
                return true;
        }
        return base.HandleAdditionalParameter(name, value);
    }
}
