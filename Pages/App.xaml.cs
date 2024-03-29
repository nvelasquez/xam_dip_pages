﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var page = new MyCarouselPage();
            MainPage = new NavigationPage(page);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
