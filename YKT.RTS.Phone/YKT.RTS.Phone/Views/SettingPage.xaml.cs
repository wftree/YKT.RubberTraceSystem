using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YKT.RubberTraceSystem.Data.Entity;
using YKT.RubberTraceSystem.Phone.Services;

namespace YKT.RubberTraceSystem.Phone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }
        private async void btnScan_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    txtBarcode.Text = result;
                    var httpClient = new HttpClient();
                    var response = await httpClient.GetStringAsync("https://localhost:44395/Api/员工/"+result);
                    try
                    {
                        var employee = JsonConvert.DeserializeObject<员工>(response);
                        if (employee != null)
                        {
                            txtResult.Text = employee.姓名;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    
                    
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}