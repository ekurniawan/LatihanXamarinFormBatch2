using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatihanXamarinApp
{
    public partial class App : Application
    {
        //
        public App()
        {
            InitializeComponent();

            //untuk menyimpan data yg bisa diakses oleh semua forms
            Application.Current.Properties["tempdata"] = string.Empty;
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
