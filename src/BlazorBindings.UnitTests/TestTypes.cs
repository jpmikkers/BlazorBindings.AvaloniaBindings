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
    //private static MethodInfo CurrentGetter;
    //private static MethodInfo BindToSelf;

    //static TestApplication()
    //{
    //    CurrentGetter = typeof(AvaloniaLocator).GetProperty("Current", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).GetGetMethod(true);
    //    BindToSelf = typeof(AvaloniaLocator).GetMethod("BindToSelf", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).MakeGenericMethod(typeof(Application));
    //}

    public TestApplication()
    {
        //AvaloniaLocator a;

        //var avaloniaLocator = ((AvaloniaLocator)CurrentGetter.Invoke(null, null));
        //BindToSelf.Invoke(avaloniaLocator, [this]);
    }

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

    //public TestApplication(IServiceProvider serviceProvider = null)
    //{
    //    serviceProvider ??= TestServiceProvider.Create();
    //    //Handler = new TestHandler
    //    //{
    //    //    MauiContext = new MauiContext(serviceProvider),
    //    //    VirtualView = this
    //    //};

    //    //DependencyService.RegisterSingleton(new TestSystemResources());
    //}

    //class TestHandler : IElementHandler
    //{
    //    public object PlatformView => null;
    //    public IElement VirtualView { get; set; }
    //    public IMauiContext MauiContext { get; set; }
    //    public void DisconnectHandler() { }
    //    public void Invoke(string command, object args = null) { }
    //    public void SetMauiContext(IMauiContext mauiContext) => MauiContext = mauiContext;
    //    public void SetVirtualView(IElement view) => VirtualView = view;
    //    public void UpdateValue(string property) { }
    //}

    //#pragma warning disable CS0612 // Type or member is obsolete. Unfortunately, I need to register this, otherwise some tests fail.
    //    class TestSystemResources : ISystemResourcesProvider
    //#pragma warning restore CS0612 // Type or member is obsolete
    //    {
    //        public IResourceDictionary GetSystemResources() => new ResourceDictionary();
    //    }
    
    public Window Window { get; set; }

    public static TestApplication Create()
    {
        //var appBuilder = AppBuilder.Configure<TestApplication>()
        //    .UsePlatformDetect()
        //    .UseSkia()
        //    .UseAvaloniaBlazorBindings(services =>
        //    {
        //        services.AddSingleton<AvaloniaBlazorBindingsRenderer, TestBlazorBindingsRenderer>();
        //    });

        //_ = Task.Run(() => appBuilder.StartWithClassicDesktopLifetime([]));

        //Task.Delay(1000).Wait();

        //return (TestApplication)appBuilder.Instance;

        var builder = TestApplication.BuildAvaloniaApp();
        builder.SetupWithoutStarting();
        var application = (TestApplication)builder.Instance;
        //application.Initialize(TestServiceProvider.Get());

        return application;
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // Don't call base.OnFrameworkInitializationCompleted() because there it tries to render the main page
    }
}

public static class TestServiceProvider
{
    public static IServiceProvider Get()
    {
        //var builder = AppBuilder.Configure<TestApplication>();
        //builder.UseAvaloniaBlazorBindings(services =>
        //{
        //    services.AddSingleton<AvaloniaBlazorBindingsRenderer, TestBlazorBindingsRenderer>();
        //    //services.AddSingleton<Avalonia., TestDispatcher>();
        //});
        //return ((TestApplication)builder.Instance).ServiceProvider;

        var services = new ServiceCollection();
        services.TryAddSingleton<AvaloniaBlazorBindingsRenderer, TestBlazorBindingsRenderer>();
        AvaloniaAppBuilderExtensions.RegisterBlazorServices(services);

        return services.BuildServiceProvider();

    }

    public static IServiceProvider Get(IAvaloniaBlazorApplication application)
    {

        return application.ServiceProvider;
    }

    //class TestDispatcher : AvaloniaDispatching.IDispatcher
    //{
    //    public bool IsDispatchRequired => false;
    //    public AvaloniaDispatching.IDispatcherTimer CreateTimer() => null;
    //    public bool Dispatch(Action action)
    //    {
    //        action();
    //        return true;
    //    }

    //    public bool DispatchDelayed(TimeSpan delay, Action action)
    //    {
    //        Thread.Sleep(delay);
    //        action();
    //        return true;
    //    }
    //}
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
