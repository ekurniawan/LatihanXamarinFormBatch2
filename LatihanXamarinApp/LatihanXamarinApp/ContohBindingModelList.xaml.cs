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
    public partial class ContohBindingModelList : ContentPage
    {
        private List<ListItem> lstItems;
        public ContohBindingModelList()
        {
            InitializeComponent();
            lstItems = new List<ListItem>
            {
                new ListItem{Title="Xamarin Android",Description="Xamarin with Traditional Android UI"},
                new ListItem{Title="Xamarin IOS",Description="Xamarin with Traditional IOS UI"},
                new ListItem{Title="Xamarin Forms",Description="Cross Platform Xamarin Forms"}
            };

            lvData.ItemsSource = lstItems;
        }
    }
}