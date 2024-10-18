// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Microsoft.Extensions.Logging;
using AvaloniaAppBuilder = global::Avalonia.AppBuilder;
using Microsoft.Extensions.DependencyInjection.Extensions;
using BlazorBindings.AvaloniaBindings.UriNavigation;
using Microsoft.AspNetCore.Components.Routing;

namespace BlazorBindings.AvaloniaBindings;

public static class AvaloniaAppBuilderExtensions
{
    public static AvaloniaAppBuilder UseAvaloniaBlazorBindings(this AvaloniaAppBuilder builder, Action<IServiceCollection> configureServices)
    {   
        ArgumentNullException.ThrowIfNull(builder);

        // Use factories for performance.
        builder.AfterSetup(b =>
        {
            IServiceProvider serviceProvider = null;

            var services = new ServiceCollection();

            configureServices?.Invoke(services);
            
            RegisterBlazorServices(services);

            serviceProvider = services.BuildServiceProvider();

            b.With(serviceProvider);


            ((IAvaloniaBlazorApplication)b.Instance).Initialize(serviceProvider);
        });

        return builder;
    }

    public static void RegisterBlazorServices(IServiceCollection services)
    {
        services.TryAddSingleton<NavigationManager, BlazorNavigationManager>();
        services.TryAddSingleton<INavigationInterception, BlazorNavigationInterception>();
        services.TryAddSingleton<IScrollToLocationHash, BlazorScrollToLocationHash>();
        services.TryAddSingleton(svcs => new AvaloniaBlazorBindingsRenderer(svcs, svcs.GetRequiredService<ILoggerFactory>()));
        services.TryAddSingleton<INavigation>(svcs => new BlazorNavigation(svcs));
        //services.TryAddSingleton(svcs => ((IAvaloniaBlazorApplication)Avalonia.Application.Current).Navigation);

        services.AddLogging();
    }
}
