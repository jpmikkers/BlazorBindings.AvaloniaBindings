using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using BlazorBindings.AvaloniaBindings.Navigation;
using Microsoft.AspNetCore.Components.RenderTree;
using System.Threading.Tasks;

namespace BlazorBindings.AvaloniaBindings;

public class BlazorBindingsApplication : Application, IAvaloniaBlazorApplication
{
    private IServiceProvider _serviceProvider = null;
    private AvaloniaNavigation _avaloniaNavigation = null;

    public BlazorBindingsApplication()
    {
    }

    public IServiceProvider ServiceProvider => _serviceProvider;

    public AvaloniaNavigation Navigation => _avaloniaNavigation;

    public Type ComponentType { get; set; }

    public virtual void Initialize(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider ?? (new ServiceCollection().BuildServiceProvider());

        Configure();

        var renderer = serviceProvider.GetRequiredService<AvaloniaBlazorBindingsRenderer>();

        if (WrapperComponentType != null)
        {
            var navigation = _serviceProvider.GetService<INavigation>();
            (navigation as BlazorNavigation)?.SetWrapperComponentType(WrapperComponentType);
        }

        RenderComponent(false);

        var navigationView = new NavigationView();
        _avaloniaNavigation = new AvaloniaNavigation(navigationView);
        Task pushTask;

        if (Avalonia.Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime classic)
        {
            pushTask = _avaloniaNavigation.PushAsync((Control)classic.MainWindow.Content, false);
            classic.MainWindow.Content = navigationView;
        }
        else if (Avalonia.Application.Current.ApplicationLifetime is ISingleViewApplicationLifetime single)
        {
            pushTask = _avaloniaNavigation.PushAsync((Control)single.MainView, false);
            single.MainView = navigationView;
        }
        else if (Avalonia.Application.Current is ITestApplication testApplication)
        {
            pushTask = _avaloniaNavigation.PushAsync((Control)testApplication.Window.Content, false);
            testApplication.Window.Content = navigationView;
        }
        else
        {
            throw new NotSupportedException($"Unsupported application lifetime '{Avalonia.Application.Current.ApplicationLifetime.GetType().FullName}'");
        }

        AwaitVoid(pushTask);
    }

    static async void AwaitVoid(Task task) => await task;

    public void RenderComponent(bool addToRoot)
    {
        var renderer = ServiceProvider.GetRequiredService<AvaloniaBlazorBindingsRenderer>();
        var (componentType, parameters) = GetComponentToRender();

        if (componentType is not null)
        {
            var task = renderer.AddComponent(componentType, this, parameters);
            AwaitVoid(task);

            if (addToRoot)
            {
                var nativeControl = ((Elements.Control)task.Result).NativeControl;

                if (Avalonia.Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime classic)
                {
                    classic.MainWindow.Content = nativeControl;
                }
                else if (Avalonia.Application.Current.ApplicationLifetime is ISingleViewApplicationLifetime single)
                {
                    single.MainView = nativeControl;
                }
                else if (Avalonia.Application.Current is ITestApplication testApplication)
                {
                    testApplication.Window.Content = nativeControl;
                }
                else
                {
                    throw new NotSupportedException($"Unsupported application lifetime '{Avalonia.Application.Current.ApplicationLifetime.GetType().FullName}'");
                }
            }
        }
    }

    public virtual Type WrapperComponentType { get; }

    /// <summary>
    /// This method is executed before the rendering. It can be used to set resources, for example.
    /// </summary>
    protected virtual void Configure() { }

    protected virtual (Type ComponentType, Dictionary<string, object> Parameters) GetComponentToRender()
    {
        if (WrapperComponentType is null)
        {
            return (ComponentType, null);
        }
        else
        {
            var parameters = new Dictionary<string, object>
            {
                ["ChildContent"] = RenderFragments.FromComponentType(ComponentType)
            };
            return (WrapperComponentType, parameters);
        }
    }
}

public class BlazorBindingsApplication<T> : BlazorBindingsApplication
    where T : IComponent
{
    public override void Initialize(IServiceProvider serviceProvider)
    {
        ComponentType = typeof(T);

        base.Initialize(serviceProvider);
    }
}
