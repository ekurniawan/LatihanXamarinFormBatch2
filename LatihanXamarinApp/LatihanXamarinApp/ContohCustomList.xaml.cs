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
    public partial class ContohCustomList : ContentPage
    {
        private List<ListItem> lstItems;
        public ContohCustomList()
        {
            InitializeComponent();
            lstItems = new List<ListItem>
            {
                new ListItem{Title="Xamarin Android",Price="12",
                    Description="Xamarin with Traditional Android UI",Source="monkey.png"},
                new ListItem{Title="Xamarin IOS",Price="20",
                    Description="Xamarin with Traditional IOS UI",Source="monkey2.png"},
                new ListItem{Title="Xamarin Forms",Price="30",
                    Description="Cross Platform Xamarin Forms",Source="monkey3.png"}
            };

            lvImage.ItemsSource = lstItems;
        }
    }
}