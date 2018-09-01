using MvvmCross;
using MvvmCross.ViewModels;
using MvvmCrossContentDialog.Core.ViewModels;

namespace MvvmCrossContentDialog.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //Mvx.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<MainViewModel>();
        }
    }
}