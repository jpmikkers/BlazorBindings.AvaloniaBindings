using BlazorBindings.AvaloniaBindings;
using Microsoft.Extensions.Logging;
using System.Runtime.ExceptionServices;

namespace BlazorBindings.UnitTests;

internal class TestBlazorBindingsRenderer : AvaloniaBlazorBindingsRenderer
{
    public TestBlazorBindingsRenderer(IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
        : base(serviceProvider, loggerFactory)
    {
    }

    public bool ThrowExceptions { get; set; } = true;

    public List<Exception> Exceptions { get; } = new();

    protected override void HandleException(Exception exception)
    {
        Exceptions.Add(exception);

        if (ThrowExceptions)
            ExceptionDispatchInfo.Throw(exception);
    }

    public override Dispatcher Dispatcher => NullDispatcher.Instance;

    public static AvaloniaBlazorBindingsRenderer Get(TestApplication application)
    {
        return application.ServiceProvider.GetRequiredService<AvaloniaBlazorBindingsRenderer>();
    }

    sealed class NullDispatcher : Dispatcher
    {
        public static readonly Dispatcher Instance = new NullDispatcher();

        private NullDispatcher()
        {
        }

        public override bool CheckAccess() => true;

        public override Task InvokeAsync(Action workItem)
        {
            workItem();
            return Task.CompletedTask;
        }

        public override Task InvokeAsync(Func<Task> workItem)
        {
            return workItem();
        }

        public override Task<TResult> InvokeAsync<TResult>(Func<TResult> workItem)
        {
            return Task.FromResult(workItem());
        }

        public override Task<TResult> InvokeAsync<TResult>(Func<Task<TResult>> workItem)
        {
            return workItem();
        }
    }
}
