using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LatihanXamarinApp
{
    //
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSimpleList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ContohListString());
        }

        private async void btnBindingList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohBindingModelList());
        }

        private async void btnImageList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohImageList());
        }

        private async void menuAbsolut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohAbsoluteLayout());
        }

        private async void menuGrid_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohGridLayout());
        }

        private async void menuCalc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohStackLayout());
        }

        private async void menuCall_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Keterangan", "Phone Call", "Yes","No");
            if (result)
                await DisplayAlert("Ket", "Anda menjawab Yes","OK");
            else
                await DisplayAlert("Ket", "Anda menjawab No","OK");
        }
    }
}
