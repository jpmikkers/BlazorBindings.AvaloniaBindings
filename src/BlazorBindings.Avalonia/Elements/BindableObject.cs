﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace BlazorBindings.AvaloniaBindings.Elements;

public abstract class BindableObject : NativeControlComponentBase, IElementHandler
{
    //private EventCallback _attached { get; set; }
    private Action<object> _attached { get; set; }

    private AvaloniaBindableObject _nativeControl;

    public AvaloniaBindableObject NativeControl => _nativeControl ??= CreateNativeElement();

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        foreach (var parameterValue in parameters)
        {
            HandleParameter(parameterValue.Name, parameterValue.Value);
        }

        await base.SetParametersAsync(ParameterView.Empty);
    }

    [UnsafeAccessor(UnsafeAccessorKind.Method, Name = "AsUntyped")]
    public static extern EventCallback AsUntyped<T>(EventCallback<T> component);

    [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "Receiver")]
    public static extern IHandleEvent? GetReceiver<T>(EventCallback<T> component);

    [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "Delegate")]
    public static extern ref MulticastDelegate? GetDelegate<T>(EventCallback<T> component);

    internal EventCallback AsUntypedEx(dynamic value)
    {
        return new EventCallback(GetReceiver(value) ?? GetDelegate(value)?.Target as IHandleEvent, GetDelegate(value));
    }

    protected virtual void HandleParameter(string name, object value)
    {
        if (name == "Attached")
        {
            ((dynamic)value).Invoke((dynamic)this);
            
            return;
        }

        if (HandleAdditionalParameter(name, value))
            return;

        if (AttachedPropertyRegistry.AttachedPropertyHandlers.TryGetValue(name, out var handler))
        {
            handler(NativeControl, value);
            return;
        }

        throw new NotImplementedException($"{GetType().FullName} doesn't recognize parameter '{name}'");
    }

    protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
    {
        RenderAdditionalPartialElementContent(builder, ref sequence);
    }

    [RequiresPreviewFeatures]
    protected virtual void RenderAdditionalPartialElementContent(RenderTreeBuilder builder, ref int sequence) { }

    protected virtual bool HandleAdditionalParameter(string name, object value) => false;

    protected abstract AvaloniaBindableObject CreateNativeElement();

    object IElementHandler.TargetElement => NativeControl;
}
