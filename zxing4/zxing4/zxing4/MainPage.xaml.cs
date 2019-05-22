using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing;

namespace zxing4 {
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            QRTest();
        }

        public void QRTest () {
            BarcodeImageView.BarcodeValue = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            BarcodeImageView.IsVisible = true;
            TheFrame.Scale = 1.5;
            TheFrame.HeightRequest = 900;
        }
    }
}
