using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Utilizities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YKT.RTS.Phone;
using YKT.RTS.Phone.Models;
using YKT.RubberTraceSystem.Phone.Models;
using YKT.RubberTraceSystem.Phone.Services;

namespace YKT.RubberTraceSystem.Phone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
            
            this.txtWebAPI.Text = Constants.RTSWebAPIEndpoint;
            this.txtBarcode.Text = Constants.USERGUID;
            var test = Constants.CheckUser(Constants.USERGUID);
            if (test != null)
                txtResult.Text = test.Result.姓名;

        }
        private async void btnScan_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    Guid? g = Utilizity.DecodeQRCode(result);
                    if (g!=null)
                    {
                        txtBarcode.Text = g.ToString();
                        var test = Constants.CheckUser(txtBarcode.Text);
                        if (test != null)
                            txtResult.Text = test.Result.姓名;
                    }
                    

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            SettingItem settingItem = new SettingItem();
            settingItem.Name = "RTSWebAPIEndpoint";
            settingItem.Value = txtWebAPI.Text;
            Constants.RTSWebAPIEndpoint = txtWebAPI.Text;
            await App.SettingDatabase.SaveItemAsync(settingItem);

            SettingItem settingItem2 = new SettingItem();
            settingItem2.Name = "USERGUID";
            settingItem2.Value = txtBarcode.Text;
            Constants.USERGUID = txtBarcode.Text;
            await App.SettingDatabase.SaveItemAsync(settingItem2);

            var test = Constants.CheckUser(txtBarcode.Text);
            if (test != null)
                txtResult.Text = test.Result.姓名;
        }
    }
}