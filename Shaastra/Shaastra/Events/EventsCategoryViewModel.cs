using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Newtonsoft.Json;
using Shaastra.Helper;

namespace Shaastra.Events
{
    class EventsCategoryViewModel
    {
        List<EventsCategoryModel> Items { get; set; }
        
        private EventsCategoryViewModel() { }

        public async Task<EventsCategoryViewModel> InitializeAsync()
        {
            try
            {
                string jsonString = await WebUtils.DownloadPageStringAsync(ShaastraWeb.EventsCategoryUri);
                Items = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<List<EventsCategoryModel>>(jsonString));
                return this;
            }
            catch (Exception exception)
            {
                await new MessageDialog(exception.Message).ShowAsync();
                throw;
            }
        }

        public static Task<EventsCategoryViewModel> CreateTaskAsync()
        {
            EventsCategoryViewModel eventsCategoryViewModel = new EventsCategoryViewModel();
            return eventsCategoryViewModel.InitializeAsync();
        }

    }
}
