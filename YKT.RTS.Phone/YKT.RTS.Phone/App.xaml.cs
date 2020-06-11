using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YKT.RTS.Phone.Services;
using YKT.RTS.Phone.Views;

namespace YKT.RTS.Phone
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
