using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Mixins;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaEdit.TextMate;
using AvaloniaEdit.TextMate.Grammars;
using Jockey.ViewModels.Controls;
using ReactiveUI;

namespace Jockey.Views.ViewControls;

public partial class EditorControl : ReactiveUserControl<EditorControlViewModel>
{
    public EditorControl()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            var  _registryOptions = new RegistryOptions(ThemeName.DarkPlus);
            var _textMateInstallation =  Editor.InstallTextMate(_registryOptions);
            _textMateInstallation.SetGrammar(_registryOptions.GetScopeByLanguageId(_registryOptions.GetLanguageByExtension(".cs").Id));
            
            this.OneWayBind(ViewModel, x => x.FontFamily, x => x.Editor.FontFamily)
                .DisposeWith(disposables);
            this.OneWayBind(ViewModel, x => x.ShowLineNumbers, x => x.Editor.ShowLineNumbers).DisposeWith(disposables);
            this.OneWayBind(ViewModel, x => x.InitText, x => x.Editor.Text).DisposeWith(disposables);
        });
    }
}