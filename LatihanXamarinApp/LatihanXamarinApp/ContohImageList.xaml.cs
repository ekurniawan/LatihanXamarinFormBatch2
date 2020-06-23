using LatihanXamarinApp.Models;
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
    public partial class ContohImageList : ContentPage
    {
        private List<ListItem> lstItems;
        public ContohImageList()
        {
            InitializeComponent();
            lstItems = new List<ListItem>
            {
                new ListItem{Title="Xamarin Android",
                    Description="Xamarin with Traditional Android UI",Source="monkey.png"},
                new ListItem{Title="Xamarin IOS",
                    Description="Xamarin with Traditional IOS UI",Source="monkey2.png"},
                new ListItem{Title="Xamarin Forms",
                    Description="Cross Platform Xamarin Forms",Source="monkey3.png"}
            };

            lvImage.ItemsSource = lstItems;
        }

        private async void lvImage_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem data = (ListItem)e.Item;
            await DisplayAlert("Keterangan", $"Anda memilih: {data.Title}", "OK");
        }
    }
}