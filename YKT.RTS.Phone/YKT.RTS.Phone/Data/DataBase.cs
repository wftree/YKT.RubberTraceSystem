
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLite;
using YKT.RubberTraceSystem.Phone.Models;
using YKT.RubberTraceSystem.Phone.Services;

namespace YKT.RubberTraceSystem.Phone.Data
{
    public class DataBase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public DataBase()
        {
            InitializeAsync().Wait();
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(SettingItem).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(SettingItem)).ConfigureAwait(false);
                    initialized = true;
                }
            }
        }

        public Task<List<SettingItem>> GetItemsAsync()
        {
            return Database.Table<SettingItem>().ToListAsync();
        }

        public Task<SettingItem> GetItemAsync(string name)
        {
            return Database.Table<SettingItem>().Where(i => i.Name == name).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(SettingItem item)
        {
            Task<SettingItem> st = Database.Table<SettingItem>().Where(i => i.Name == item.Name).FirstOrDefaultAsync();
            if (st.Result != null)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(SettingItem item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
