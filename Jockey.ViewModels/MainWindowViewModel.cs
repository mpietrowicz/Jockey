using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using DynamicData;
using DynamicData.Binding;
using Jockey.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace Jockey.ViewModels;

public class MainWindowViewModel : ViewModelBase, IActivatableViewModel
{
    private ObservableCollectionExtended<MainMenuItem> MenuItemsSource { get; set; }
    private ReadOnlyObservableCollection<MainMenuItem> _menuItems = null;
    public ReadOnlyObservableCollection<MainMenuItem> MenuItems => _menuItems;

    public MainWindowViewModel()
    {
        Activator = new();
        this.WhenActivated(disposables =>
        {
            this.HandleActivation();
            MenuItemsSource.ToObservableChangeSet()
                .Bind(out _menuItems)
                .Subscribe();
            
            
            Disposable
                .Create(HandleDeactivation)
                .DisposeWith(disposables);
        });
    }


    public ViewModelActivator Activator { get; }

    internal override void HandleActivation()
    {
        MenuItemsSource  =  Locator.Current.GetService<MainSettings>()?.MenuItems ?? new ObservableCollectionExtended<MainMenuItem>();
    }

    internal override void HandleDeactivation()
    {
    }
}