using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Headless.NUnit;
using BlazorBindings.AvaloniaBindings;
using BlazorBindings.UnitTests.Components;

namespace BlazorBindings.UnitTests;

public class BlazorBindingsApplicationTests
{
    private TestApplication _application;
    private Window _window;
    private TestBlazorBindingsRenderer _renderer;

    [SetUp]
    public void Setup()
    {
        
    }

    [AvaloniaTest]
    public void SetsTheMainPage_ContentPage()
    {
        var application = CreateApplication<PageContent>();
        
        application.RenderComponent(true);

        PageContent.ValidateContent(_window);
    }

    [AvaloniaTest]
    public void SetsTheMainPage_WithRootWrapper()
    {
        var application = CreateApplicationWithWrapper<PageContentWithCascadingParameter, WrapperWithCascadingValue>();

        application.RenderComponent(true);

        PageContentWithCascadingParameter.ValidateContent((StyledElement)_window.Content, WrapperWithCascadingValue.Value);
    }

    private BlazorBindingsApplication CreateApplication<T>() where T : IComponent
    {
        _application = (TestApplication)Application.Current;
        _application.ComponentType = typeof(T);
        _renderer = (TestBlazorBindingsRenderer)TestBlazorBindingsRenderer.Get(_application);

        Avalonia.Threading.Dispatcher.UIThread.VerifyAccess();
        _window = new Window
        {
            Width = 100,
            Height = 100
        };
        _application.Window = _window;

        return _application;
    }

    private static BlazorBindingsApplication<TMain> CreateApplicationWithWrapper<TMain, TWrapper>()
        where TMain : IComponent
        where TWrapper : IComponent
    {
        return new BlazorBindingsApplicationWithWrapper<TMain, TWrapper>(TestServiceProvider.Get());
    }

    class BlazorBindingsApplicationWithWrapper<TMain, TWrapper> : BlazorBindingsApplication<TMain>
        where TMain : IComponent
        where TWrapper : IComponent
    {
        public BlazorBindingsApplicationWithWrapper(IServiceProvider serviceProvider) 
        {
            Initialize(serviceProvider);
        }

        public override Type WrapperComponentType => typeof(TWrapper);
    }
}
