using System.Diagnostics;
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
        
        // this.WhenActivated(disposables =>
        // {
        //     this.WhenAnyValue(x => x.FontFamily).Subscribe(fontFamily =>
        //     {
        //         this.RaisePropertyChanged(nameof(FontFamily));
        //     });
        // });
    }

    internal override void HandleActivation()
    {
        throw new NotImplementedException();
    }

    internal override void HandleDeactivation()
    {
        throw new NotImplementedException();
    }
}