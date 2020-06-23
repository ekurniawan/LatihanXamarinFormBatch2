﻿using System;
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
            MainPage = new ContohImageList();
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
