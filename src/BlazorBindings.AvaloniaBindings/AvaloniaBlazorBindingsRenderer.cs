﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.AvaloniaBindings.Elements.Handlers;
using Microsoft.Extensions.Logging;
using System.Runtime.ExceptionServices;

namespace BlazorBindings.AvaloniaBindings;

public class AvaloniaBlazorBindingsRenderer : NativeComponentRenderer
{
    public AvaloniaBlazorBindingsRenderer(IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
        : base(serviceProvider, loggerFactory)
    {
    }

    public override Dispatcher Dispatcher { get; } = new AvaloniaDispatcher();

    public Task<IComponent> AddComponent(Type componentType, AvaloniaApplication parent, Dictionary<string, object> parameters = null)
    {
        var handler = new ApplicationHandler(parent);
        var addComponentTask = AddComponent(componentType, handler, parameters);

        if (addComponentTask.Exception != null)
        {
            // If exception was thrown during the sync execution - throw it straight away.
            ExceptionDispatchInfo.Throw(addComponentTask.Exception.InnerException);
        }

        if (!addComponentTask.IsCompleted && parent is AvaloniaApplication app)
        {
            // Avalonia requires the Application to have the MainPage. If rendering task is not completed synchronously,
            // we need to set MainPage to something.
            //app.MainPage ??= new AC.ContentPage();
        }

        return addComponentTask;
    }

    public async Task<T> AddComponent<T>(AvaloniaApplication parent, Dictionary<string, object> parameters = null)
        where T : IComponent
    {
        var result = await AddComponent(typeof(T), parent, parameters);

        return (T)result;
    }

    protected override void HandleException(Exception exception)
    {
        ExceptionDispatchInfo.Throw(exception);
    }

    // It tries to return the Element as soon as it is available, therefore Component task might still be in progress.
    internal async Task<(object Element, Task<IComponent> Component)> GetElementFromRenderedComponent(Type componentType, Dictionary<string, object> parameters = null)
    {
        var (elements, addComponentTask) = await GetElementsFromRenderedComponent(componentType, parameters);

        if (elements.Count != 1)
        {
            throw new InvalidOperationException("The target component must have exactly one root element.");
        }

        return (elements[0], addComponentTask);
    }

    internal async Task<(T Component, int ComponentId)> AddRootComponent<T>(Dictionary<string, object> initialParameters)
        where T : IComponent
    {
        var component = (T)InstantiateComponent(typeof(T));
        var componentId = AssignRootComponentId(component);
        await RenderRootComponentAsync(componentId, ParameterView.FromDictionary(initialParameters));
        return (component, componentId);
    }

    private async Task<(List<object> Elements, Task<IComponent> Component)> GetElementsFromRenderedComponent(Type componentType, Dictionary<string, object> parameters)
    {
        var container = new RootContainerHandler();

        var addComponentTask = AddComponent(componentType, container, parameters);
        var elementAddedTask = container.WaitForElementAsync();

        await Task.WhenAny(addComponentTask, elementAddedTask);

        if (addComponentTask.Exception != null)
        {
            var exception = addComponentTask.Exception.InnerException;
            ExceptionDispatchInfo.Throw(exception);
        }

        return (container.Elements, addComponentTask);
    }
}
