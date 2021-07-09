using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp7.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand ScannerPageCommand { get; set;  }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";


            
            this.ScannerPageCommand = new DelegateCommand(async() =>
            {
                bool allowed = await GoogleVisionBarCodeScanner.Methods.AskForRequiredPermission();

                await NavigationService.NavigateAsync("ScannerPage");
            });
        }
    }
}
