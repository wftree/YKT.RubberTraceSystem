using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using YKT.RTS.Phone.Models;
using YKT.RTS.Phone.Views;
using YKT.RubberTraceSystem.Phone.Services;

namespace YKT.RTS.Phone.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "本日产品";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                if(!Constants.IsCheckedUser)
                {
                    return;
                }
                Items.Clear();
                var items = await Constants.GetSummary(Constants.User.Id);
                int num = 1;
                foreach (var item in items)
                {
                    var temp = new Item();
                    temp.Id = num.ToString();
                    temp.Text = item[0];
                    temp.Description = item[1];
                    Items.Add(temp);
                    num++;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
            //IsBusy = true;

            //try
            //{
            //    Items.Clear();
            //    var items = await DataStore.GetItemsAsync(true);
            //    foreach (var item in items)
            //    {
            //        Items.Add(item);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(ex);
            //}
            //finally
            //{
            //    IsBusy = false;
            //}
        }
    }
}