﻿using System.Net.Http;
using System.Threading.Tasks;

namespace Shaastra.Helper
{
    class WebUtils
    {
        public static async Task<string> DownloadPageStringAsync(string url)
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                UseDefaultCredentials = true, AllowAutoRedirect = true
            };

            HttpClient client = new HttpClient(handler);
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
