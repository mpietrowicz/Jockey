using System.Diagnostics;
using System.Reactive.Disposables;
using Avalonia.Controls;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Jockey.ViewModels.Controls;

public class EditorControlViewModel : ViewModelBase, IActivatableViewModel
{
    [Reactive]
    public string FontFamily { get; set; } = "Cascadia Code,Consolas,Menlo,Monospace";
    [Reactive]
    public bool ShowLineNumbers { get; set; } = true;
    
    [Reactive]
    public string InitText { get; set; } = "Loading...";

    public ViewModelActivator Activator { get; } = new();

    public EditorControlViewModel()
    {
        if (Design.IsDesignMode)
        {
            InitText = "public class Program\n{\n    public static void Main()\n    {\n        Console.WriteLine(\"Hello World!\");\n    }\n}";
            return;
        }
        
        this.WhenActivated(disposables =>
        {
            this.HandleActivation();
            InitText = "public class Program\n{\n    public static void Main()\n    {\n        Console.WriteLine(\"Hello World!\");\n    }\n}";
            Disposable
                .Create(this.HandleDeactivation)
                .DisposeWith(disposables);
        });
    }

    internal override void HandleActivation()
    {
    }

    internal override void HandleDeactivation()
    {
    }
}