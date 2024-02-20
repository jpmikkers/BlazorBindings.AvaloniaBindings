﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.AvaloniaBindings.Elements;

namespace BlazorBindings.UnitTests.Elements;

public class ElementTests
{
    [Test]
    public void NativeControlShouldReturnInstance_TextBox()
        => Assert.That(new TextBox().NativeControl, Is.Not.Null);

    [Test]
    public void NativeControlShouldReturnInstance_Label()
        => Assert.That(new Label().NativeControl, Is.Not.Null);

    [Test]
    public void NativeControlShouldReturnInstance_ItemsControl()
        => Assert.That(new ItemsControl<string>().NativeControl, Is.Not.Null);

    [Test]
    public void NativeControlShouldReturnInstance_ContentPage()
        => Assert.That(new ContentControl().NativeControl, Is.Not.Null);

    //[Test]
    //public void NativeControlShouldReturnNullWhenHandlerNotInitialized_TapGestureRecognizer()
    //    => Assert.That(new TapGestureRecognizer().NativeControl, Is.Not.Null);
}
