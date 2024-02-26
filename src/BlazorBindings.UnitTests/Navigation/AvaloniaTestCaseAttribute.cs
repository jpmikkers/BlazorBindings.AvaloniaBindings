// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Avalonia.Headless;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Commands;

namespace BlazorBindings.UnitTests.Navigation;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
public sealed class AvaloniaTestCaseAttribute : TestCaseAttribute, IWrapSetUpTearDown
{
    /// <summary>
    /// Construct a TestCaseAttribute with a list of arguments.
    /// This constructor is not CLS-Compliant
    /// </summary>
    /// <param name="arguments"></param>
    public AvaloniaTestCaseAttribute(params object?[]? arguments)
        :base(arguments)
    {
    }

    /// <summary>
    /// Construct a AvaloniaTestCaseAttribute with a single argument
    /// </summary>
    /// <param name="arg"></param>
    public AvaloniaTestCaseAttribute(object? arg)
        : base(arg)
    {
    }

    /// <summary>
    /// Construct a AvaloniaTestCaseAttribute with a two arguments
    /// </summary>
    /// <param name="arg1"></param>
    /// <param name="arg2"></param>
    public AvaloniaTestCaseAttribute(object? arg1, object? arg2)
        : base(arg1, arg2)
    {
    }

    /// <summary>
    /// Construct a AvaloniaTestCaseAttribute with a three arguments
    /// </summary>
    /// <param name="arg1"></param>
    /// <param name="arg2"></param>
    /// <param name="arg3"></param>
    public AvaloniaTestCaseAttribute(object? arg1, object? arg2, object? arg3)
        : base(arg1, arg2, arg3)
    {
    }

    public TestCommand Wrap(TestCommand command)
    {
        var session = HeadlessUnitTestSession.GetOrStartForAssembly(command.Test.Method?.MethodInfo.DeclaringType?.Assembly);

        var type = Type.GetType("Avalonia.Headless.NUnit.AvaloniaTestMethodCommand", assemblyName => typeof(AvaloniaTestAttribute).Assembly, (assembly, typeName, caseInsensitive) => typeof(AvaloniaTestAttribute).Assembly.GetType(typeName));
        var method = type.GetMethod("ProcessCommand", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.InvokeMethod, [typeof(HeadlessUnitTestSession), typeof(TestCommand)]);
        //return AvaloniaTestMethodCommand.ProcessCommand(session, command);
        return (TestCommand)method.Invoke(null, [session, command]);
    }
}
