using System.Reactive;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Jockey.Models;

public class MainMenuItem : ReactiveObject
{
    public MainMenuItem()
    {
        Items = new();
        Header = string.Empty;
        Command =ReactiveCommand.CreateFromTask(()=> Task.CompletedTask);
        // Command =ReactiveCommand.CreateFromTask()
    }

    public ReactiveCommand<Unit, Unit> Command { get; set; }

    [Reactive]
    public string Header { get; set; }
    public ObservableCollectionExtended<MainMenuItem> Items { get; set; }
    public object CommandParameter { get; }
}