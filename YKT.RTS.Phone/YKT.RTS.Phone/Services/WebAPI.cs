using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using YKT.RTS.Phone.Models;

namespace YKT.RubberTraceSystem.Phone.Services
{
    public static class Constants
    {
        private static WebAPI restService = new WebAPI();
        public static string RTSWebAPIEndpoint = "http://192.168.31.17:12345/Api/";
        public static string USERGUID = "";
        public static bool IsCheckedUser = false;
        public static string OpenWeatherMapAPIKey = "INSERT_API_KEY_HERE";

        public const string DatabaseFilename = "DbSQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;
        public static async Task<员工> CheckUser(string result)
        {
            var response = await Constants.RestService.GetWebAPIAsync(Constants.RTSWebAPIEndpoint + "员工?id=" + result);
            try
            {
                var employee = JsonConvert.DeserializeObject<员工>(response);
                if (employee != null)
                {

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
        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }

        public static WebAPI RestService { get => restService; set => restService = value; }
    }
    public class WebAPI
    {
        HttpClient _client;

        public WebAPI()
        {
            _client = new HttpClient();
        }

        public async Task<string> GetWebAPIAsync(string uri)
        {
            string content ="";
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    content = await response.Content.ReadAsStringAsync();
                    
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return content;
        }
    }
}
