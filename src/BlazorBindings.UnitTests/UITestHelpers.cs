using Avalonia.Controls;
using Avalonia.Interactivity;

namespace BlazorBindings.UnitTests;

public static class UITestHelpers
{
    public static void ClickTrigger(this Button button)
    {
        button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
    }
}