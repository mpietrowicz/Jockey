using Avalonia.Controls;
using Avalonia.Controls.Mixins;
using Avalonia.ReactiveUI;
using Jockey.ViewModels;
using ReactiveUI;

namespace Jockey.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, x => x.MenuItems, x => x.MainMenu.Items)
                .DisposeWith(disposables);
        });
    }
}