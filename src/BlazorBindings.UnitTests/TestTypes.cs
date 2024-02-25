using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Headless;
using BlazorBindings.AvaloniaBindings;
using BlazorBindings.AvaloniaBindings.Navigation;
using BlazorBindings.Core;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Threading;
//using MauiDispatching = Microsoft.Maui.Dispatching;

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

internal class TestBlazorBindingsRenderer : AvaloniaBlazorBindingsRenderer
{
    public TestBlazorBindingsRenderer(IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
        : base(serviceProvider, loggerFactory)
    {
    }

    public bool ThrowExceptions { get; set; } = true;

    public List<Exception> Exceptions { get; } = new();

    protected override void HandleException(Exception exception)
    {
        Exceptions.Add(exception);

        if (ThrowExceptions)
            ExceptionDispatchInfo.Throw(exception);
    }

    public override Dispatcher Dispatcher => NullDispatcher.Instance;

    public static AvaloniaBlazorBindingsRenderer Get(TestApplication application)
    {
        return application.ServiceProvider.GetRequiredService<AvaloniaBlazorBindingsRenderer>();
    }

    sealed class NullDispatcher : Dispatcher
    {
        public static readonly Dispatcher Instance = new NullDispatcher();

        private NullDispatcher()
        {
        }

        public override bool CheckAccess() => true;

        public override Task InvokeAsync(Action workItem)
        {
            workItem();
            return Task.CompletedTask;
        }

        public override Task InvokeAsync(Func<Task> workItem)
        {
            return workItem();
        }

        public override Task<TResult> InvokeAsync<TResult>(Func<TResult> workItem)
        {
            return Task.FromResult(workItem());
        }

        public override Task<TResult> InvokeAsync<TResult>(Func<Task<TResult>> workItem)
        {
            return workItem();
        }
    }
}
