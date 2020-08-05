using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Android.Net;
using Xamarin.Forms;
using YKT.RTS.Phone.Models;

namespace YKT.RubberTraceSystem.Phone.Services
{
    public static class Constants
    {
        private static WebAPI restService = new WebAPI();
        private static string rTSWebAPIEndpoint = @"http://172.16.10.109:8080/Api/";
        public static string USERGUID = "";
        public static 员工 User = null;
        public static string MCGUID = "";
        public static 机台 Machine = null;
        public static bool IsCheckedUser = false;
        public static bool IsCheckedMc = false;
        public static string OpenWeatherMapAPIKey = "INSERT_API_KEY_HERE";

        public const string DatabaseFilename = "DbSQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static async Task<机台> CheckMc(string result)
        {
            using (WebAPI webAPI = new WebAPI())
            {
                var response = await webAPI.GetWebAPIAsync(Constants.RTSWebAPIEndpoint + "Machine?id=" + result);
                try
                {
                    var employee = JsonConvert.DeserializeObject<机台>(response);
                    if (employee != null)
                    {
                        Constants.Machine = employee;
                        Constants.IsCheckedMc = true;

                    }
                    else
                    {
                        IsCheckedMc = false;
                    }
                    return employee;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        public static async Task<员工> CheckUser(string result)
        {
            using (WebAPI webAPI = new WebAPI())
            {
                var response = await webAPI.GetWebAPIAsync(Constants.RTSWebAPIEndpoint + "Labor?id=" + result);
                try
                {
                    var employee = JsonConvert.DeserializeObject<员工>(response);
                    if (employee != null)
                    {
                        Constants.User = employee;

                        Constants.IsCheckedUser = true;

                    }
                    else
                    {
                        IsCheckedUser = false;
                    }
                    return employee;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            
        }
        public static async Task<List<string>> GetMT(Picker picker)
        {
            using (WebAPI webAPI = new WebAPI())
            {
                var response = await webAPI.GetWebAPIAsync(Constants.RTSWebAPIEndpoint + "MT");
                try
                {
                    picker.Items.Clear();
                    picker.Items.Add("");
                    var employee = JsonConvert.DeserializeObject<List<string>>(response);
                    if (employee != null)
                    {
                        foreach (var item in employee)
                        {
                            picker.Items.Add(item);
                        }
                        
                        return employee;

                    }
                    else
                    {
                        return new List<string>();
                    }
                    
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        public static async Task<橡胶薄片> GetRC(Guid id, Guid lb)
        {
            using (WebAPI webAPI = new WebAPI())
            {
                var response = await webAPI.GetWebAPIAsync(Constants.RTSWebAPIEndpoint + "RC?id=" + id.ToString()+"&lb="+lb.ToString());
                try
                {
                    var employee = JsonConvert.DeserializeObject<橡胶薄片>(response);
                    return employee;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }

        public static async Task<帘布流转> GetFC(Guid id, Guid lb)
        {
            using (WebAPI webAPI = new WebAPI())
            {
                var response = await webAPI.GetWebAPIAsync(Constants.RTSWebAPIEndpoint + "FC?id=" + id.ToString() + "&lb=" + lb.ToString());
                try
                {
                    var employee = JsonConvert.DeserializeObject<帘布流转>(response);
                    return employee;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }

        public static async Task<皮囊成型> GetNP(Guid id, Guid lb,Guid machine)
        {
            using (WebAPI webAPI = new WebAPI())
            {
                var response = await webAPI.GetWebAPIAsync(Constants.RTSWebAPIEndpoint + "NP?id=" + id.ToString() + "&lb=" + lb.ToString()+"&machine="+machine.ToString());
                try
                {
                    var employee = JsonConvert.DeserializeObject<皮囊成型>(response);
                    return employee;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }

        public static async Task<皮囊成型> GetNP(string id, Guid lb, Guid machine)
        {
            using (WebAPI webAPI = new WebAPI())
            {
                var response = await webAPI.GetWebAPIAsync(Constants.RTSWebAPIEndpoint + "NP?id=" + id + "&lb=" + lb.ToString() + "&machine=" + machine.ToString());
                try
                {
                    var employee = JsonConvert.DeserializeObject<皮囊成型>(response);
                    return employee;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }

        public static async Task<皮囊硫化> GetCP(string id, Guid lb, Guid machine, float temp, float time)
        {
            using (WebAPI webAPI = new WebAPI())
            {
                var response = await webAPI.GetWebAPIAsync(Constants.RTSWebAPIEndpoint + "CP?id=" + id + "&lb=" + lb.ToString() + "&machine=" + machine.ToString()+"&temp="+temp.ToString()+"&time="+time.ToString());
                try
                {
                    var employee = JsonConvert.DeserializeObject<皮囊硫化>(response);
                    return employee;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }
        public static async Task<检验修边> GetCC(string id, Guid lb, bool pass, string mt)
        {
            using (WebAPI webAPI = new WebAPI())
            {
                var response = await webAPI.GetWebAPIAsync(Constants.RTSWebAPIEndpoint + "CC?id=" + id + "&lb=" + lb.ToString() + "&pass=" + pass.ToString() + "&mt=" + mt.ToString() );
                try
                {
                    var employee = JsonConvert.DeserializeObject<检验修边>(response);
                    return employee;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }

        public static async Task<List<string[]>> GetSummary(Guid id)
        {
            using (WebAPI webAPI = new WebAPI())
            {
                var response = await webAPI.GetWebAPIAsync(Constants.RTSWebAPIEndpoint + "summary?id=" + id.ToString());
                try
                {
                    var employee = JsonConvert.DeserializeObject<List<string[]>>(response);
                    return employee;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }
        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }

        public static WebAPI RestService { get => restService; set => restService = value; }
        public static string RTSWebAPIEndpoint { 
            get => rTSWebAPIEndpoint.EndsWith("/")? rTSWebAPIEndpoint: rTSWebAPIEndpoint.Trim()+"/"
                ; set => rTSWebAPIEndpoint = value; }
    }
    public class WebAPI:IDisposable
    {
        HttpClient _client;

        public WebAPI()
        {
            _client = new HttpClient();
        }

        public void Dispose()
        {
            _client.Dispose();
        }

        public async Task<string> GetWebAPIAsync(string uri)
        {
            string content ="";
            try
            {
                //content = await _client.GetStringAsync(uri);
                HttpResponseMessage response = await _client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                content = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return content;
        }
    }
}
