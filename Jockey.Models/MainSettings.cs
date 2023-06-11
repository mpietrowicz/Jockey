using DynamicData.Binding;
using ReactiveUI;

namespace Jockey.Models;

public class MainSettings : ReactiveObject
{
   public ObservableCollectionExtended<MainMenuItem> MenuItems { get; set; }
    public MainSettings()
    {
        MenuItems = new()
        {
            new MainMenuItem()
            {
                Header = "_File"
            }
        };
        
    }
}