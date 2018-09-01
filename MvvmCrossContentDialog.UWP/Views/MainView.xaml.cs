using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using MvvmCrossContentDialog.Core.Interfaces;
using MvvmCrossContentDialog.Core.ViewModels;
using MvvmCrossContentDialog.UWP.Services;

namespace MvvmCrossContentDialog.UWP.Views
{
    [MvxViewFor(typeof(MainViewModel))]
    public sealed partial class MainView : MvxWindowsPage
    {
        public MainView()
        {
            InitializeComponent();
            //ISpeechDialogService dialog = new SpeechDialogService();
            //MainViewModel = new MainViewModel(dialog);
        }

        //public MainViewModel MainViewModel { get; set; }
    }
}