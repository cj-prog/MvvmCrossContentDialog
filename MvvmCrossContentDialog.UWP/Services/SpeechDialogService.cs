using System;
using System.Threading.Tasks;
using MvvmCrossContentDialog.Core.Interfaces;
using MvvmCrossContentDialog.UWP.Views;

namespace MvvmCrossContentDialog.UWP.Services
{
    public class SpeechDialogService : ISpeechDialogService
    {
        public async Task ShowAsync()
        {
            //var contentDialog = new ContentDialog();
            var contentDialog = new Speech();
            await contentDialog.ShowAsync();

        }
    }
}