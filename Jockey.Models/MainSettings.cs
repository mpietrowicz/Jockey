using DynamicData.Binding;
using ReactiveUI;

namespace Jockey.Models;

public class MainSettings : ReactiveObject
{
   public ObservableCollectionExtended<MainMenuItem> MenuItems { get; set; }
    public MainSettings()
    {
        InitializeMenu();
    }

    private void InitializeMenu()
    {
        MenuItems = new()
        {
            new MainMenuItem()
            {
                Header = "_File",
                Items = new ObservableCollectionExtended<MainMenuItem>()
                {
                    new MainMenuItem()
                    {
                        Header = "_Open",
                    },
                     new MainMenuItem()
                    {
                        Header = "_Exit",
                        Command = ReactiveCommand.Create(()=>
                        {
                            Environment.Exit(0);
                        })
                    }
                }
            }
        };
    }
}