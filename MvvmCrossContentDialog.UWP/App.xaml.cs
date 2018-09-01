using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace MvvmCrossContentDialog.UWP
{
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class DialogApp : MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {
    }
}
