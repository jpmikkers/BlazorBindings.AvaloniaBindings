using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
//using MauiDispatching = Microsoft.Maui.Dispatching;

namespace BlazorBindings.UnitTests;

public static class UITestHelpers
{
    public static void ClickTrigger(this Button button)
    {
        button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
    }
}
//public class FuncBinding<TIn, TOut> : Binding
//{
//    public FuncBinding(Func<TIn,TOut> selector)
//    {
//        Selector = selector;
//    }

//    public Func<TIn, TOut> Selector { get; }

//    override 
//}