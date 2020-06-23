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

        private void lvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            string nama = e.Item.ToString();
            DisplayAlert("Keterangan", $"Anda memilih nama: {nama}","OK");
        }
    }
}