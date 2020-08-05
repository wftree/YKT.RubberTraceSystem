using System;
using System.Threading.Tasks;
using Utilizities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YKT.RTS.Phone.Models;
using YKT.RubberTraceSystem.Phone.Services;

namespace YKT.RTS.Phone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkPage : TabbedPage
    {
        public WorkPage()
        {
            InitializeComponent();
            
        }

        private async void  btnScanRC_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    if(!result.StartsWith("RC"))
                    {
                        await DisplayAlert("警告", "错误代码类型", "确定");
                        return;
                    }
                    txtRC.Text = Utilizity.DecodeQRCode(result).Value.ToString();
                }
            }
            catch (Exception ex)
            {

                //throw ex;
            }
        }

        private async void btnSaveRC_Clicked(object sender, EventArgs e)
        {
            if(Constants.User == null)
            {
                await DisplayAlert("警告", "未识别操作者", "确定");
                return;
            }
            if (txtRC.Text == null|| txtRC.Text =="")
            {
                await DisplayAlert("警告", "无扫描数据", "确定");
                return;
            }
            var temp = await Constants.GetRC(Utilizity.DecodeQRCode(txtRC.Text).Value, Constants.User.Id);
            if(temp!=null)
            {
                txtRCResult.Text = "已登记：" + temp.生产时间.ToString();
            }
        }

        private async void btnScanFC_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    if (!result.StartsWith("FC"))
                    {
                        await DisplayAlert("警告", "错误代码类型", "确定");
                        return;
                    }
                    txtFC.Text = Utilizity.DecodeQRCode(result).Value.ToString(); 
                }
            }
            catch (Exception ex)
            {

                //throw ex;
            }
        }

        private async void btnSaveFC_Clicked(object sender, EventArgs e)
        {
            if (Constants.User == null)
            {
                await DisplayAlert("警告", "未识别操作者", "确定");
                return;
            }
            if (txtFC.Text == null || txtFC.Text == "")
            {
                await DisplayAlert("警告", "无扫描数据", "确定");
                return;
            }
            var temp = await Constants.GetFC(Utilizity.DecodeQRCode(txtFC.Text).Value, Constants.User.Id);
            if (temp != null)
            {
                txtFCResult.Text = "已登记：" + temp.生产时间.ToString();
            }
        }

        private async void btnScanNP_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    if (!result.StartsWith("NP"))
                    {
                        await DisplayAlert("警告", "错误代码类型", "确定");
                        return;
                    }
                    txtNP.Text = Utilizity.DecodeQRHashCode(result);
                }
            }
            catch (Exception ex)
            {

                //throw ex;
            }
        }

        private async void btnSaveNP_Clicked(object sender, EventArgs e)
        {
            if (!Constants.IsCheckedUser)
            {
                await DisplayAlert("警告", "未识别操作者", "确定");
                return;
            }
            if (!Constants.IsCheckedMc)
            {
                await DisplayAlert("警告", "未识别机台", "确定");
                return;
            }
            if (txtNP.Text == null || txtNP.Text == "")
            {
                await DisplayAlert("警告", "无扫描数据", "确定");
                return;
            }
            var temp = await Constants.GetNP(Utilizity.DecodeQRHashCode(txtNP.Text), Constants.User.Id,Constants.Machine.Id);
            if (temp != null)
            {
                txtNPResult.Text = "已登记：" + temp.生产时间.ToString();
            }
        }

        private async void btnScanCP_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    if (!result.StartsWith("NP"))
                    {
                        await DisplayAlert("警告", "错误代码类型", "确定");
                        return;
                    }
                    txtCP.Text = Utilizity.DecodeQRHashCode(result);
                }
            }
            catch (Exception ex)
            {

                //throw ex;
            }
        }

        private async void btnSaveCP_Clicked(object sender, EventArgs e)
        {
            if (!Constants.IsCheckedUser)
            {
                await DisplayAlert("警告", "未识别操作者", "确定");
                return;
            }
            if (!Constants.IsCheckedMc)
            {
                await DisplayAlert("警告", "未识别机台", "确定");
                return;
            }
            if (txtCP.Text == null || txtCP.Text == "")
            {
                await DisplayAlert("警告", "无扫描数据", "确定");
                return;
            }
            try
            {
                var temp = await Constants.GetCP(Utilizity.DecodeQRHashCode(txtCP.Text), Constants.User.Id, Constants.Machine.Id, Convert.ToSingle(txtCPTemp.Text), Convert.ToSingle(txtCPTime.Text));
                if (temp != null)
                {
                    txtCPResult.Text = "已登记：" + temp.生产时间.ToString();
                }
            }
            catch (Exception)
            {

                await DisplayAlert("警告", "失败操作", "确定");
            }
            
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            swOk.IsToggled = picker.SelectedIndex == 0;
        }

        private async void btnSaveCC_Clicked(object sender, EventArgs e)
        {
            if (!Constants.IsCheckedUser)
            {
                await DisplayAlert("警告", "未识别操作者", "确定");
                return;
            }
            if (!Constants.IsCheckedMc)
            {
                await DisplayAlert("警告", "未识别机台", "确定");
                return;
            }
            if (txtCC.Text == null || txtCC.Text == "")
            {
                await DisplayAlert("警告", "无扫描数据", "确定");
                return;
            }
            try
            {
                检验修边 temp;
                if (picker.SelectedItem!=null)
                {
                    temp = await Constants.GetCC(Utilizity.DecodeQRHashCode(txtCC.Text), Constants.User.Id, swOk.IsToggled, picker.SelectedItem.ToString());
                }
                else
                {
                    temp = await Constants.GetCC(Utilizity.DecodeQRHashCode(txtCC.Text), Constants.User.Id, swOk.IsToggled, "");
                }
                if (temp != null)
                {
                    txtCCResult.Text = "已登记：" + (temp.结果 ? "合格" : "不合格");
                }
            }
            catch (Exception)
            {

                await DisplayAlert("警告", "失败操作", "确定");
            }
        }

        private async void btnScanCC_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    if (!result.StartsWith("NP"))
                    {
                        await DisplayAlert("警告", "错误代码类型", "确定");
                        return;
                    }
                    txtCC.Text = Utilizity.DecodeQRHashCode(result);
                }
            }
            catch (Exception ex)
            {

                //throw ex;
            }
        }

        private void swOk_Toggled(object sender, ToggledEventArgs e)
        {
            if(swOk.IsToggled)
                picker.SelectedIndex = 0;
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            await Constants.GetMT(picker);
        }
    }
}