
using Avalonia;

namespace BlazorBindings.UnitTests;

public class TestProperties : AvaloniaObject
{
    public static readonly AvaloniaProperty ComponentProperty = AvaloniaProperty.RegisterAttached<AvaloniaObject, IComponent>("Component", typeof(TestProperties));
}
