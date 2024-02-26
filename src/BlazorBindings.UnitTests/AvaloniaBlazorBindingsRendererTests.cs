using Avalonia;
using Avalonia.Controls;
using Avalonia.Headless.NUnit;
using BlazorBindings.UnitTests.Components;
using FluentAssertions;

namespace BlazorBindings.UnitTests;

public class AvaloniaBlazorBindingsRendererTests
{
    private TestApplication _application;
    private Window _window;
    private TestBlazorBindingsRenderer _renderer;

    [SetUp]
    public void Setup()
    {
        _application = (TestApplication)Application.Current;
        _renderer = (TestBlazorBindingsRenderer)TestBlazorBindingsRenderer.Get(_application);

        Avalonia.Threading.Dispatcher.UIThread.VerifyAccess();
        _window = new Window
        {
            Width = 100,
            Height = 100
        };
        _application.Window = _window;
        _window.Show();
    }

    [TearDown]
    public void TearDown()
    {
        //((IClassicDesktopStyleApplicationLifetime)_application?.ApplicationLifetime).Shutdown();

        Assert.That(_application, Is.EqualTo(Application.Current));

        Avalonia.Threading.Dispatcher.UIThread.VerifyAccess();
        _window.Close();
    }
    

    [AvaloniaTest]
    public async Task RenderToApplication_PageContent()
    {
        await _renderer.AddComponent<PageContent>(_application);

        var content = (AC.Control)_window.Content;
        PageContent.ValidateContent(content);
    }

    [AvaloniaTest]
    public async Task ShouldThrowExceptionIfHappenedDuringSyncRenderAsync()
    {
        var action = () => _ = _renderer.AddComponent<ComponentWithException>(_application);

        action.Should().ThrowAsync<InvalidOperationException>().Result.WithMessage("Should fail here.");
    }

    [AvaloniaTest]
    public async Task RendererShouldHandleAsyncExceptions()
    {
        _renderer.ThrowExceptions = false;

        await _renderer.AddComponent<PageWithButtonWithExceptionOnClick>(_application);
        var button = (AC.Button)((AC.ContentControl)(_window.Content)).Content;
        button.ClickTrigger();

        await Task.Delay(20);
        Assert.That(() => _renderer.Exceptions, Is.Not.Empty);
        Assert.That(_renderer.Exceptions[0].Message, Is.EqualTo("HandleExceptionTest"));
    }

    [AvaloniaTest]
    public async Task RenderedComponentShouldBeAbleToReplaceMainPage()
    {
        await _renderer.AddComponent(typeof(SwitchablePages), _application);

        ((AC.ContentControl)_window.Content).Tag.Should().Be("Page1");

        var switchButton = (AC.Button)((AC.ContentControl)(_window.Content)).Content;
        switchButton.ClickTrigger();

        ((AC.ContentControl)_window.Content).Tag.Should().Be("Page2");

        switchButton = (AC.Button)((AC.ContentControl)(_window.Content)).Content;
        switchButton.ClickTrigger();

        ((AC.ContentControl)_window.Content).Tag.Should().Be("Page1");
    }
}
