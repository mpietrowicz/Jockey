using DynamicData.Binding;
using ReactiveUI;

namespace Jockey.Models;

public class WorkspaceNode : ReactiveObject
{
    public ObservableCollectionExtended<WorkspaceNode> Items { get; set; } = new();
    public string Name { get; }

    public WorkspaceNode()
    {
        Name = String.Empty;
    }
}