using Avalonia;
using Avalonia.Markup.Xaml;

namespace ControlGallery;

public class App : ControlGalleryApplication
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        base.OnFrameworkInitializationCompleted();

        this.AttachDevTools();
    }
}
