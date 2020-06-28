using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace YKT.RTS.Phone.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "关于";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("http://www.ytairspring.com/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}