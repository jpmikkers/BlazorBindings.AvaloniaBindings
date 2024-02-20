using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using System.Reflection;

namespace BlazorBindings.UnitTests.Extensions;

public static class ControlsExtensions
{
    //public static T GetTemplateContent<T>(this TemplatedControl view) where T : Control
    //{
    //    //return (T)((ContentView)view.Children[0]).Content;
    //    return (T)((ContentControl)view.get.Children[0]).Content;Avalonia.Controls.Templates.
    //}

    //public static T GetTemplateContent<T>(this object templateRoot) where T : Control
    //{
    //    return (T)((ContentControl)templateRoot).Content;
    //    //return (T)((ContentView)templateRoot).Content;
    //}

    public static TemplateResult<Control> CreateContent(this Avalonia.Controls.Templates.IControlTemplate controlTemplate)
    {
        var button = new Avalonia.Controls.Button();
        var result = controlTemplate.Build(button);
        return result;
    }

    public static T GetTemplateContent<T>(this ContentControl contentControl)
    {
        return (T)contentControl.Content;
    }

    public static T GetTemplateContent<T>(this TemplateResult<Control> templateResult)
        where T : Control
    {
        return (T)templateResult.Result;
    }

    public static void RaiseEvent<T>(this Avalonia.AvaloniaObject bindableObject, string eventName, T args)
    {
        var declaringType = bindableObject.GetType().GetEvent(eventName).DeclaringType;
        var backingField = declaringType.GetField(eventName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
        var delegateInstance = (EventHandler<T>)backingField.GetValue(bindableObject);
        delegateInstance?.Invoke(null, args);
    }
}
