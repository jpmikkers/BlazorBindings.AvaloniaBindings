using Avalonia;
using Avalonia.Controls;
using Avalonia.Headless;
using BlazorBindings.AvaloniaBindings;

[assembly: AvaloniaTestApplication(typeof(BlazorBindings.UnitTests.TestApplication))]

namespace BlazorBindings.UnitTests;

public class TestApplication : BlazorBindingsApplication, IAvaloniaBlazorApplication, ITestApplication
{
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

    public static TestApplication Create()
    {
        var builder = TestApplication.BuildAvaloniaApp();
        builder.SetupWithoutStarting();
        var application = (TestApplication)builder.Instance;

        return application;
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // Don't call base.OnFrameworkInitializationCompleted() because there it tries to render the main page
    }
}
