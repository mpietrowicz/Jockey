using DynamicData.Binding;
using Jockey.Models;
using ReactiveUI;

namespace Jockey.ViewModels.Controls;

public class WorkspaceControlViewModel : ViewModelBase, IActivatableViewModel
{
    public ObservableCollectionExtended<WorkspaceNode> Items { get; set; } = new();

    public WorkspaceControlViewModel()
    {
        
    }
    
    internal override void HandleActivation()
    {
        throw new NotImplementedException();
    }

    internal override void HandleDeactivation()
    {
        throw new NotImplementedException();
    }

    public ViewModelActivator Activator { get; } = new ViewModelActivator();
}