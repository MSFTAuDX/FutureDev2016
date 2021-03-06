﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DXNewsApp
{
    // simple static class which lets us access our viewmodel
    public static class ViewModelLocator
    {
        static MainViewModel mainViewModel;

        public static MainViewModel ViewModel  => mainViewModel
            ?? (mainViewModel = new MainViewModel(
                new DXNewsDesignData(new Uri("http://dxnews.azurewebsites.net/"))));
    }

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DXNewsApp.MainPage());
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
