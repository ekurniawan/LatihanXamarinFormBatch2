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
    public partial class ShowEmployeePage : ContentPage
    {
        public ShowEmployeePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var results = App.DbAccess.GetAllEmployee();
            lvEmployee.ItemsSource = results;
        }

        private async void btnAddEmployee_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployeePage());
        }
    }
}