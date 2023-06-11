using Jockey.Abstraction;
using ReactiveUI;

namespace Jockey.ViewModels;

public abstract class ViewModelBase : ReactiveObject, IViewModel
{
    internal abstract void HandleActivation();

    internal abstract void HandleDeactivation();
}