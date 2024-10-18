using Avalonia;
using Avalonia.Controls;
using Avalonia.Headless;
using Avalonia.Platform;
using Avalonia.Themes.Fluent;
using BlazorBindings.AvaloniaBindings;

[assembly: AvaloniaTestApplication(typeof(BlazorBindings.UnitTests.TestApplication))]

namespace BlazorBindings.UnitTests;

public class TestApplication : BlazorBindingsApplication, IAvaloniaBlazorApplication, ITestApplication
{
    public TestApplication()
    {
        Styles.Add(new FluentTheme());
    }

    public Window Window { get; set; }

    public static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<TestApplication>()
        .UseSkia()
        .UseHeadless(new AvaloniaHeadlessPlatformOptions
        {
            UseHeadlessDrawing = false
        })
        .UseAvaloniaBlazorBindings(services =>
        {
            services.AddSingleton<AvaloniaBlazorBindingsRenderer, TestBlazorBindingsRenderer>();
        });
}
