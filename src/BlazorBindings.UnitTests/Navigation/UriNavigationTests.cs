using Avalonia.Threading;
using BlazorBindings.AvaloniaBindings;
using BlazorBindings.AvaloniaBindings.Navigation;
using BlazorBindings.UnitTests.Components;
using BlazorBindings.UnitTests.TestUtils;

namespace BlazorBindings.UnitTests.Navigation;

public class UriNavigationTests
{
    private BlazorNavigation _navigationService;
    private AvaloniaNavigation _nativeNavigation;

    [SetUp]
    public async Task SetupAsync()
    {
        var app = (TestApplication)Avalonia.Application.Current;
        var serviceProvider = app.ServiceProvider;

        _navigationService = (BlazorNavigation)serviceProvider.GetRequiredService<INavigation>();
        _nativeNavigation = app.Navigation;

        await _nativeNavigation.PushAsync(new AC.ContentControl(), false);
    }

    //[AvaloniaTest]
    [AvaloniaTestCase("/test/path/TestTitle123/subpath")]
    [AvaloniaTestCase("/test/path/TestTitle123")]
    public async Task NavigateToPageWithUrlParameters(string uri)
    {
        // it doesn't work if using TestCase
        await SetupAsync();

        await _navigationService.NavigateToAsync(uri);

        var nativePage = _nativeNavigation.NavigationStack.Last();
        Assert.That(nativePage.Tag, Is.EqualTo("TestTitle123"));
        PageWithUrl.ValidateContent(nativePage);
    }

    [AvaloniaTest]
    public async Task NavigateToPageWithIntParameter()
    {
        await _navigationService.NavigateToAsync("/test/int-route/42/subpath");

        var nativePage = _nativeNavigation.NavigationStack.Last();
        PageWithUrl.ValidateContent(nativePage, i: 42);
    }

    [AvaloniaTestCase("/test/nullable-long-route/1234", 1234L)]
    [AvaloniaTestCase("/test/nullable-long-route/", null)]
    public async Task NavigateToPageWithNullableLongParameter(string uri, long? expectedValue)
    {
        // it doesn't work if using TestCase
        await SetupAsync();

        await _navigationService.NavigateToAsync(uri);

        var nativePage = _nativeNavigation.NavigationStack.Last();
        PageWithUrl.ValidateContent(nativePage, l: expectedValue);
    }

    [AvaloniaTest]
    public async Task NavigateToPageWithDateTimeParameterWithoutRouteConstraint()
    {
        await _navigationService.NavigateToAsync("/test/datetime/03-29-2023/without-constraint");

        var nativePage = _nativeNavigation.NavigationStack.Last();
        PageWithUrl.ValidateContent(nativePage, dt: new DateTime(2023, 03, 29));
    }

    [AvaloniaTest]
    public async Task NavigateToPageWithAdditionalParameter()
    {
        var lines = new[] { "Hello there!", "General Kenobi!" };
        await _navigationService.NavigateToAsync("/test/path/TestTitle123", new()
        {
            ["AdditionalText"] = lines
        });

        Tick();

        var nativePage = _nativeNavigation.NavigationStack.Last();
        PageWithUrl.ValidateContent(nativePage, additionalLines: lines);
    }

    [AvaloniaTest]
    public void ShouldFailIfRouteConstraintDoesNotMatch()
    {
        Assert.That(() => _navigationService.NavigateToAsync("/test/int-route/not-an-int/subpath"),
            Throws.InvalidOperationException.With.Message.Contains("not registered"));
    }

    [AvaloniaTest]
    public void ShouldFailIfRouteNotFound()
    {
        Assert.That(() => _navigationService.NavigateToAsync("/non/existing/route"),
            Throws.InvalidOperationException.With.Message.Contains("not registered"));
    }

    [AvaloniaTest]
    public async Task ComponentShouldBeDisposedOnPopAsync()
    {
        await _navigationService.NavigateToAsync($"/test/path/DisposeTest");
        var nativePage = _nativeNavigation.NavigationStack.Last();
        var component = (PageWithUrl)nativePage.GetValue(TestProperties.ComponentProperty);

        var isDisposed = false;
        component.OnDispose += () => isDisposed = true;

        Tick();

        await _nativeNavigation.PopAsync(false);

        Tick();

        Assert.That(isDisposed);
    }

    [AvaloniaTest]
    public async Task NavigatedComponentShouldBeAbleToReplacePage()
    {
        await _navigationService.NavigateToAsync("/switchable-pages");
        var navigatedPage = _nativeNavigation.NavigationStack.Last();

        Assert.That(_nativeNavigation.NavigationStack.Count, Is.EqualTo(2));
        Assert.That(navigatedPage.Tag, Is.EqualTo("Page1"));

        var switchButton = (AC.Button)((AC.ContentControl)navigatedPage).Content;
        switchButton.ClickTrigger();
        navigatedPage = _nativeNavigation.NavigationStack.Last();

        Assert.That(_nativeNavigation.NavigationStack.Count, Is.EqualTo(2));
        Assert.That(navigatedPage.Tag, Is.EqualTo("Page2"));

        switchButton = (AC.Button)((AC.ContentControl)navigatedPage).Content;
        switchButton.ClickTrigger();
        navigatedPage = _nativeNavigation.NavigationStack.Last();

        Assert.That(_nativeNavigation.NavigationStack.Count, Is.EqualTo(2));
        Assert.That(navigatedPage.Tag, Is.EqualTo("Page1"));
    }

    [AvaloniaTest]
    public async Task PushPageWithRootWrapper()
    {
        _navigationService.SetWrapperComponentType(typeof(WrapperWithCascadingValue));

        await _navigationService.NavigateToAsync("/page-with-cascading-param");
        var navigatedPage = _nativeNavigation.NavigationStack.Last();

        PageContentWithCascadingParameter.ValidateContent(navigatedPage, WrapperWithCascadingValue.Value);
    }

    private void Tick()
    {
        Avalonia.Threading.Dispatcher.UIThread.RunJobs(DispatcherPriority.SystemIdle);
    }
}
