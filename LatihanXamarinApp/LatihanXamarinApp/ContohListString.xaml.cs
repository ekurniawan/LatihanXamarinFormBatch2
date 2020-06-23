using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatihanXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContohListString : ContentPage
    {
        public ContohListString()
        {
            InitializeComponent();
            List<string> items = new List<string>
            {
                "Budi",
                "Erick",
                "Joni",
                "Bambang"
            };
            lvData.ItemsSource = items;
        }


        private async void lvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            string nama = e.Item.ToString();
            await DisplayAlert("Keterangan", $"Anda memilih nama: {nama}","OK");


        }

        private async void btnMainMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}