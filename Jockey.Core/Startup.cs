using System.Reflection;
using Jockey.Models;
using Jockey.ViewModels;
using Jockey.Views;
using ReactiveUI;
using Splat;

namespace Jockey.Core;

public static class Startup
{
    public static void Configure()
    {
        Locator.CurrentMutable.RegisterViewsForViewModels(typeof(MainWindow).Assembly);
        Locator.CurrentMutable.Register(() => new MainSettings());
    }

    public static void BeforeOnFrameworkInitializationCompleted()
    {
        // Method intentionally left empty.
    }

    public static void AfterOnFrameworkInitializationCompleted()
    {
        // Method intentionally left empty.
    }
}