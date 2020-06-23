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
    public partial class ContohAmbilInput : ContentPage
    {
        public ContohAmbilInput()
        {
            InitializeComponent();

            var data = Application.Current.Properties["tempdata"].ToString();
            lblInput.Text = $"Input dari form lain {data}";
        }
        
        //overloading constructor
        public ContohAmbilInput(string nama)
        {
            InitializeComponent();
            lblInput.Text = $"Input dari form lain: {nama}";
        }
    }
}