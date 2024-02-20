// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Avalonia;
using BlazorBindings.AvaloniaBindings;
using BlazorBindings.AvaloniaBindings.Navigation;
using BlazorBindings.UnitTests.Components;

namespace BlazorBindings.UnitTests.Navigation;

public class NonUriNavigationTests
{
    private readonly AvaloniaBindings.BlazorNavigation _navigationService;
    private readonly AvaloniaNavigation _nativeNavigation;
    private readonly AC.Control _rootPage;

    public NonUriNavigationTests(string root)
    {
        //var mainPage = root == nameof(MC.Shell)
        //    ? (MC.Page)new MC.Shell { Items = { new AC.ContentControl{ /*Title = "Root"*/ } } }
        var blazorNavigation = new NavigationView { /*Title = "Root"*/ };
        var nativeNavigation = new AvaloniaNavigation(blazorNavigation);

        //var sp = TestServiceProvider.Create();
        //MC.Application.Current = new TestApplication(sp) { main = mainPage };
        var appBuilder = AppBuilder.Configure<TestApplication>()
            .UsePlatformDetect()
            .UseSkia()
            .UseAvaloniaBlazorBindings(services =>
            {
            });

        var serviceProvider = ((TestApplication)appBuilder.Instance).ServiceProvider;

        //var ctx = MC.Application.Current.Handler.MauiContext;
        //var dsp = ctx.Services.GetService<IDispatcher>();

        _navigationService = serviceProvider.GetRequiredService<BlazorNavigation>();
        _nativeNavigation = nativeNavigation;
        _rootPage = _nativeNavigation.NavigationStack[0];
    }

    [Test]
    public async Task PushAsyncWithParameters()
    {
        var par1 = "Test6543";
        var par2 = 3242342;

        await _navigationService.PushAsync<PageContentWithParameters>(new()
        {
            [nameof(PageContentWithParameters.Par1)] = par1,
            [nameof(PageContentWithParameters.Par2)] = par2
        });

        var navigatedPage = _nativeNavigation.NavigationStack.Last();
        PageContentWithParameters.ValidateContent(navigatedPage, par1, par2);
    }

    [Test]
    public async Task PushAsyncWithParameters_RenderFragment()
    {
        var par1 = "Test6543";
        var par2 = 3242342;
        var renderFragment = NavigationRenderFragments.PageWithParameters(par1, par2);

        await _navigationService.PushAsync(renderFragment);

        var navigatedPage = _nativeNavigation.NavigationStack.Last();
        PageContentWithParameters.ValidateContent(navigatedPage, par1, par2);
    }

    [Test]
    public async Task PushModalAsyncWithParameters()
    {
        var par1 = "Test6543";
        var par2 = 3242342;

        await _navigationService.PushModalAsync<PageContentWithParameters>(new()
        {
            [nameof(PageContentWithParameters.Par1)] = par1,
            [nameof(PageContentWithParameters.Par2)] = par2
        });

        var navigatedPage = _nativeNavigation.ModalStack.Last();
        PageContentWithParameters.ValidateContent(navigatedPage, par1, par2);
    }

    [Test]
    public async Task PushModalAsyncWithParameters_RenderFragment()
    {
        var par1 = "Test6543";
        var par2 = 3242342;
        var renderFragment = NavigationRenderFragments.PageWithParameters(par1, par2);

        await _navigationService.PushModalAsync(renderFragment);

        var navigatedPage = _nativeNavigation.ModalStack.Last();
        PageContentWithParameters.ValidateContent(navigatedPage, par1, par2);
    }

    [Test]
    public async Task PopAsync()
    {
        await _navigationService.PushAsync<PageContent>();

        Assert.That(_nativeNavigation.NavigationStack, Has.Count.EqualTo(2));

        await _navigationService.PopAsync();

        Assert.That(_nativeNavigation.NavigationStack, Has.Count.EqualTo(1));
        Assert.That(_nativeNavigation.NavigationStack[0], Is.EqualTo(_rootPage));
    }

    [Test]
    public async Task PopToRootAsync()
    {
        await _navigationService.PushAsync<PageContent>();
        await _navigationService.PushAsync<PageContentWithParameters>();

        Assert.That(_nativeNavigation.NavigationStack, Has.Count.EqualTo(3));

        await _navigationService.PopToRootAsync();

        Assert.That(_nativeNavigation.NavigationStack, Has.Count.EqualTo(1));
        Assert.That(_nativeNavigation.NavigationStack[0], Is.EqualTo(_rootPage));
    }

    [Test]
    public async Task PopModalAsync()
    {
        await _navigationService.PushModalAsync<PageContent>();

        Assert.That(_nativeNavigation.ModalStack, Has.Count.EqualTo(1));

        await _navigationService.PopModalAsync();

        Assert.That(_nativeNavigation.ModalStack, Has.Count.EqualTo(0));
    }

    [Test]
    public async Task ComponentShouldBeDisposedOnPopAsync()
    {
        var isDisposed = false;
        await _navigationService.PushAsync<PageContentWithDispose>();
        var mauiPage = _nativeNavigation.NavigationStack.Last();
        var component = (PageContentWithDispose)mauiPage.GetValue(TestProperties.ComponentProperty);
        component.OnDispose += () => isDisposed = true;

        await _navigationService.PopAsync();

        Assert.That(isDisposed);
    }

    [Test]
    public async Task NavigatedComponentShouldBeAbleToReplacePage()
    {
        await _navigationService.PushAsync<SwitchablePages>();
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

    [Test]
    public async Task NavigatedModalShouldBeAbleToReplacePage()
    {
        await _navigationService.PushModalAsync<SwitchablePages>();
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

    [Test]
    public async Task PushPageWithRootWrapper()
    {
        _navigationService.SetWrapperComponentType(typeof(WrapperWithCascadingValue));

        await _navigationService.PushAsync<PageContentWithCascadingParameter>();
        var navigatedPage = _nativeNavigation.NavigationStack.Last();

        PageContentWithCascadingParameter.ValidateContent(navigatedPage, WrapperWithCascadingValue.Value);
    }

    [Test]
    public async Task PushModalWithRootWrapper()
    {
        _navigationService.SetWrapperComponentType(typeof(WrapperWithCascadingValue));

        await _navigationService.PushModalAsync<PageContentWithCascadingParameter>();
        var navigatedPage = _nativeNavigation.ModalStack.Last();

        PageContentWithCascadingParameter.ValidateContent(navigatedPage, WrapperWithCascadingValue.Value);
    }
}
