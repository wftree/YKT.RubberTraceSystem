using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using YKT.RTS.Phone.Models;
using YKT.RubberTraceSystem.Phone.Services;
using YKT.RubberTraceSystem.Phone.Views;

namespace YKT.RTS.Phone.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();
            #region 检查参数
            //远程服务器
            var web = App.SettingDatabase.GetItemAsync("RTSWebAPIEndpoint");
            if (web.Result != null)
            Constants.RTSWebAPIEndpoint = web.Result.Value;
            //员工登记
            var user = App.SettingDatabase.GetItemAsync("USERGUID");
            if (user.Result != null)
            {
                Constants.USERGUID = user.Result.Value;
                var test = Constants.CheckUser(Constants.USERGUID);
                //if (test.Result != null)
                //{
                //    Constants.User = test.Result;
                //}

            }

                //机台登记
            var mc = App.SettingDatabase.GetItemAsync("MCGUID");
            if (mc.Result != null)
            {
                Constants.MCGUID = mc.Result.Value;
                var test1 = Constants.CheckMc(Constants.MCGUID);
                //if (test1.Result != null)
                //{
                //    Constants.Machine = test1.Result;
                //}
            }
            
            
            #endregion
            MasterBehavior = MasterBehavior.Popover;

            //MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Setting:
                        MenuPages.Add(id, new NavigationPage(new SettingPage()));
                        break;
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Work:
                        MenuPages.Add(id, new NavigationPage(new WorkPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}