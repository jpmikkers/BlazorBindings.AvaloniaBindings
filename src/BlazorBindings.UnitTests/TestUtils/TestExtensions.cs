namespace BlazorBindings.UnitTests.TestUtils;

public static class TestExtensions
{
    public static T Cast<T>(this object obj)
    {
        return (T)obj;
    }
}