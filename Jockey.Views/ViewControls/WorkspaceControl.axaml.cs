using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Jockey.ViewModels.Controls;

namespace Jockey.Views.ViewControls;

public partial class WorkspaceControl : ReactiveUserControl<WorkspaceControlViewModel>
{
    public WorkspaceControl()
    {
        InitializeComponent();
        
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}