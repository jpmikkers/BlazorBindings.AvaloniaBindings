using Avalonia;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Themes.Fluent;
using BlazorBindings.AvaloniaBindings;
using System;

namespace BlazorBindings.AvaloniaBindings.HelloWorld;

public class App : BlazorBindingsApplicationMainPage
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        base.OnFrameworkInitializationCompleted();

        this.AttachDevTools();
    }
}
