using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilizities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YKT.RTS.Phone;
using YKT.RubberTraceSystem.Phone.Models;
using YKT.RubberTraceSystem.Phone.Services;

namespace YKT.RubberTraceSystem.Phone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : TabbedPage
    {
        public SettingPage()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            try
            {
                txtWebAPI.Text = Constants.RTSWebAPIEndpoint;
                txtBarcode.Text = Constants.USERGUID == null ? "" : Constants.USERGUID;
                txtMachineCode.Text = Constants.MCGUID == null ? "" : Constants.MCGUID;
                if (Constants.User != null)
                {
                    txtResult.Text = Constants.User.姓名;
                }
                if (Constants.Machine != null)
                {
                    txtMachine.Text = Constants.Machine.机台编号 + Constants.Machine.机台名称;
                }
            }
            catch (Exception ex)
            {

                //throw ex;
            }
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
                    if (g != null)
                    {
                        txtBarcode.Text = g.ToString();
                        Constants.USERGUID = g.ToString();

                    }
                    await Constants.CheckUser(Constants.USERGUID);

                    BindData();

                }
            }
            catch (Exception ex)
            {

                //throw ex;
            }
        }
        private async void btnScanMC_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    Guid? g = Utilizity.DecodeQRCode(result);
                    if (g != null)
                    {
                        txtMachineCode.Text = g.ToString();
                        Constants.MCGUID = g.ToString();
                    }
                    await Constants.CheckMc(Constants.MCGUID);

                    BindData();

                }
            }
            catch (Exception ex)
            {

                //throw ex;
            }
        }
        private async void btnScanAddress_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    txtWebAPI.Text = result;
                    Constants.RTSWebAPIEndpoint = result;
                }
            }
            catch (Exception ex)
            {

                //throw ex;
            }
        }

        private async void btnSaveUser_Clicked(object sender, EventArgs e)
        {
            SettingItem settingItem2 = new SettingItem();
            settingItem2.Name = "USERGUID";
            settingItem2.Value = txtBarcode.Text;
            Constants.USERGUID = txtBarcode.Text;
            await App.SettingDatabase.SaveItemAsync(settingItem2);

            
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            SettingItem settingItem = new SettingItem();
            settingItem.Name = "RTSWebAPIEndpoint";
            settingItem.Value = txtWebAPI.Text;
            Constants.RTSWebAPIEndpoint = txtWebAPI.Text;
            await App.SettingDatabase.SaveItemAsync(settingItem);

            
        }

        private async void btnSaveMC_Clicked(object sender, EventArgs e)
        {
            SettingItem settingItem3 = new SettingItem();
            settingItem3.Name = "MCGUID";
            settingItem3.Value = txtMachineCode.Text;
            Constants.MCGUID = txtMachineCode.Text;
            await App.SettingDatabase.SaveItemAsync(settingItem3);

            
        }
    }
}