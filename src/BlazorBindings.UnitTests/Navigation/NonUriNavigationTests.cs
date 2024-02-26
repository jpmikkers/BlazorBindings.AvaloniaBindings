// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Avalonia;
using Avalonia.Headless;
using Avalonia.Threading;
using BlazorBindings.AvaloniaBindings;
using BlazorBindings.AvaloniaBindings.Navigation;
using BlazorBindings.UnitTests.Components;

namespace BlazorBindings.UnitTests.Navigation;

public class NonUriNavigationTests
{
    private BlazorNavigation _navigationService;
    private AvaloniaNavigation _nativeNavigation;
    private AC.Control _rootPage;

    [SetUp]
    public async Task SetupAsync()
    {
        var app = (TestApplication)Avalonia.Application.Current;
        var serviceProvider = app.ServiceProvider;

        _navigationService = (BlazorNavigation)serviceProvider.GetRequiredService<INavigation>();
        _nativeNavigation = app.Navigation;

        await _nativeNavigation.PushAsync(new AC.ContentControl(), false);

        _rootPage = _nativeNavigation.NavigationStack[0];
    }

    [AvaloniaTest]
    public async Task PushAsyncWithParameters()
    {
        var par1 = "Test6543";
        var par2 = 3242342;

        await _navigationService.PushAsync<PageContentWithParameters>(new()
        {
            [nameof(PageContentWithParameters.Par1)] = par1,
            [nameof(PageContentWithParameters.Par2)] = par2
        }, animated: false);

        var navigatedPage = _nativeNavigation.NavigationStack.Last();
        PageContentWithParameters.ValidateContent(navigatedPage, par1, par2);
    }

    [AvaloniaTest]
    public async Task PushAsyncWithParameters_RenderFragment()
    {
        var par1 = "Test6543";
        var par2 = 3242342;
        var renderFragment = NavigationRenderFragments.PageWithParameters(par1, par2);

        await _navigationService.PushAsync(renderFragment, animated: false);

        var navigatedPage = _nativeNavigation.NavigationStack.Last();
        PageContentWithParameters.ValidateContent(navigatedPage, par1, par2);
    }

    [AvaloniaTest]
    public async Task PushModalAsyncWithParameters()
    {
        var par1 = "Test6543";
        var par2 = 3242342;

        await _navigationService.PushModalAsync<PageContentWithParameters>(new()
        {
            [nameof(PageContentWithParameters.Par1)] = par1,
            [nameof(PageContentWithParameters.Par2)] = par2
        }, animated: false);

        var navigatedPage = _nativeNavigation.ModalStack.Last();
        PageContentWithParameters.ValidateContent(navigatedPage, par1, par2);
    }

    [AvaloniaTest]
    public async Task PushModalAsyncWithParameters_RenderFragment()
    {
        var par1 = "Test6543";
        var par2 = 3242342;
        var renderFragment = NavigationRenderFragments.PageWithParameters(par1, par2);

        await _navigationService.PushModalAsync(renderFragment, animated: false);

        var navigatedPage = _nativeNavigation.ModalStack.Last();
        PageContentWithParameters.ValidateContent(navigatedPage, par1, par2);
    }

    [AvaloniaTest]
    public async Task PopAsync()
    {
        await _navigationService.PushAsync<PageContent>(animated: false);

        Assert.That(_nativeNavigation.NavigationStack, Has.Count.EqualTo(2));

        await _navigationService.PopAsync(animated: false);

        Assert.That(_nativeNavigation.NavigationStack, Has.Count.EqualTo(1));
        Assert.That(_nativeNavigation.NavigationStack[0], Is.EqualTo(_rootPage));
    }

    [AvaloniaTest]
    public async Task PopToRootAsync()
    {
        await _navigationService.PushAsync<PageContent>(animated: false);
        await _navigationService.PushAsync<PageContentWithParameters>(animated: false);

        Assert.That(_nativeNavigation.NavigationStack, Has.Count.EqualTo(3));

        await _navigationService.PopToRootAsync(animated: false);

        Assert.That(_nativeNavigation.NavigationStack, Has.Count.EqualTo(1));
        Assert.That(_nativeNavigation.NavigationStack[0], Is.EqualTo(_rootPage));
    }

    [AvaloniaTest]
    public async Task PopModalAsync()
    {
        await _navigationService.PushModalAsync<PageContent>(animated: false);

        Assert.That(_nativeNavigation.ModalStack, Has.Count.EqualTo(1));

        await _navigationService.PopModalAsync(animated: false);

        Assert.That(_nativeNavigation.ModalStack, Has.Count.EqualTo(0));
    }

    [AvaloniaTest]
    public async Task ComponentShouldBeDisposedOnPopAsync()
    {
        var isDisposed = false;
        await _navigationService.PushAsync<PageContentWithDispose>(animated: false);
        var nativePage = _nativeNavigation.NavigationStack.Last();
        var component = (PageContentWithDispose)nativePage.GetValue(TestProperties.ComponentProperty);
        component.OnDispose += () => isDisposed = true;

        Tick();

        await _navigationService.PopAsync(animated: false);

        Tick();

        Assert.That(isDisposed);
    }

    [AvaloniaTest]
    public async Task NavigatedComponentShouldBeAbleToReplacePage()
    {
        await _navigationService.PushAsync<SwitchablePages>(animated: false);
        var navigatedPage = _nativeNavigation.NavigationStack.Last();

        Tick();

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
    public async Task NavigatedModalShouldBeAbleToReplacePage()
    {
        await _navigationService.PushModalAsync<SwitchablePages>(animated: false);
        var navigatedPage = _nativeNavigation.ModalStack.Last();

        Assert.That(_nativeNavigation.ModalStack.Count, Is.EqualTo(1));
        Assert.That(navigatedPage.Tag, Is.EqualTo("Page1"));

        var switchButton = (AC.Button)((AC.ContentControl)navigatedPage).Content;
        switchButton.ClickTrigger();
        navigatedPage = _nativeNavigation.ModalStack.Last();

        Assert.That(_nativeNavigation.ModalStack.Count, Is.EqualTo(1));
        Assert.That(navigatedPage.Tag, Is.EqualTo("Page2"));

        switchButton = (AC.Button)((AC.ContentControl)navigatedPage).Content;
        switchButton.ClickTrigger();
        navigatedPage = _nativeNavigation.ModalStack.Last();

        Assert.That(_nativeNavigation.ModalStack.Count, Is.EqualTo(1));
        Assert.That(navigatedPage.Tag, Is.EqualTo("Page1"));
    }

    [AvaloniaTest]
    public async Task PushPageWithRootWrapper()
    {
        _navigationService.SetWrapperComponentType(typeof(WrapperWithCascadingValue));

        await _navigationService.PushAsync<PageContentWithCascadingParameter>();
        var navigatedPage = _nativeNavigation.NavigationStack.Last();

        PageContentWithCascadingParameter.ValidateContent(navigatedPage, WrapperWithCascadingValue.Value);
    }

    [AvaloniaTest]
    public async Task PushModalWithRootWrapper()
    {
        _navigationService.SetWrapperComponentType(typeof(WrapperWithCascadingValue));

        await _navigationService.PushModalAsync<PageContentWithCascadingParameter>();
        var navigatedPage = _nativeNavigation.ModalStack.Last();

        PageContentWithCascadingParameter.ValidateContent(navigatedPage, WrapperWithCascadingValue.Value);
    }

    private void Tick()
    {
        Avalonia.Threading.Dispatcher.UIThread.RunJobs(DispatcherPriority.SystemIdle);
    }
}
