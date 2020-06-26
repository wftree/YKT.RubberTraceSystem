﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YKT.RTS.Phone.Services;
using YKT.RTS.Phone.Views;
using YKT.RubberTraceSystem.Phone.Services;

namespace YKT.RTS.Phone
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<QRScanningService>();
            MainPage = new MainPage();
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
