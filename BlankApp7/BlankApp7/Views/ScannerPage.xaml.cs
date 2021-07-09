using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BlankApp7.Views
{
    public partial class ScannerPage : ContentPage
    {
        public ScannerPage()
        {
            InitializeComponent();
        }

        private void CameraView_OnDetected(object sender, GoogleVisionBarCodeScanner.OnDetectedEventArg e)
        {
            List<GoogleVisionBarCodeScanner.BarcodeResult> obj = e.BarcodeResults;

            string result = string.Empty;
            for (int i = 0; i < obj.Count; i++)
            {
                result += $"{i + 1}. Type : {obj[i].BarcodeType}, Value : {obj[i].DisplayValue}{Environment.NewLine}";
            }
            Device.BeginInvokeOnMainThread(async () =>
            {
                await DisplayAlert("Result", result, "OK");

                GoogleVisionBarCodeScanner.Methods.SetIsScanning(true);
            });
        }
    }
}
