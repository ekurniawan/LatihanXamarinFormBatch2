using LatihanXamarinApp.DAL;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatihanXamarinApp
{
    public partial class App : Application
    {
        //singleton pattern
        private static DataAccess dbAccess;
        public static DataAccess DbAccess
        {
            get
            {
                if (dbAccess == null)
                    dbAccess = new DataAccess();
                return dbAccess;
            }
        }

        //
        public App()
        {
            InitializeComponent();

            //untuk menyimpan data yg bisa diakses oleh semua forms
            Application.Current.Properties["tempdata"] = string.Empty;
            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new MyMasterDetailPage();
            MainPage = new AddEmployeePage();
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
