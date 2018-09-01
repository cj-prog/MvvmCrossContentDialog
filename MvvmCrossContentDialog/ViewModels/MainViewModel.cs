using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using MvvmCrossContentDialog.Core.Interfaces;

namespace MvvmCrossContentDialog.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        readonly ISpeechDialogService _dialog;

        public MainViewModel()
        {
        }

        public MainViewModel(ISpeechDialogService dialog)
        {
            _dialog = dialog;
        }

        private ICommand _call;
        public ICommand Call => _call ?? (_call = new MvxCommand(DoCall));


        public async void DoCall()
        {
            await _dialog.ShowAsync();
        }
    }
}