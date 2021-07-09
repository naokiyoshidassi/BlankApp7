using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp7.ViewModels
{
    public class ScannerPageViewModel : BindableBase
    {
        private bool _isCameraVisible;
        public bool IsCameraVisible
        {
            get { return _isCameraVisible; }
            set { SetProperty(ref _isCameraVisible, value); }
        }
        public DelegateCommand ShowGVCommand { get; set; }
        public ScannerPageViewModel()
        {
            this.ShowGVCommand = new DelegateCommand(() =>
            {
                IsCameraVisible = !IsCameraVisible;
                GoogleVisionBarCodeScanner.Methods.SetIsScanning(IsCameraVisible);
            });
        }
    }
}
