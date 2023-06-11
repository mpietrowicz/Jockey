using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Jockey.Abstraction;
using Jockey.Core;
using Jockey.ViewModels;
using Jockey.Views;

namespace Jockey;

public partial class App : Application, IApp
{
    public App()
    {
        Startup.Configure();
    }
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        Startup.BeforeOnFrameworkInitializationCompleted();
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
        }

        base.OnFrameworkInitializationCompleted();
        Startup.AfterOnFrameworkInitializationCompleted();
    }
}