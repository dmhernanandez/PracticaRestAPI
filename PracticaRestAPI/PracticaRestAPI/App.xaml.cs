﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
namespace PracticaRestAPI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage());
            Debug.WriteLine("hola");
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
