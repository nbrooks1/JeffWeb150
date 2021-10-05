using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShowsSite.Services
{
    public class TopShowsService
    {
        private readonly HttpClient _client;

        public TopShowsService(HttpClient client)
        {
            _client = client;
            _client.DefaultRequestHeaders.Add("User-Agent", "ShowsSite");
        }

        public async Task<TopShowsResponse> GetTopShowsAsync()
        {
            var response = await _client.GetAsync("/topshows");
            // do some error handling (TODO)
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TopShowsResponse>(content);
        }
    }


    public class TopShowsResponse
    {
        public TopShowItem[] data { get; set; }
    }

    public class TopShowItem
    {
        public int id { get; set; }
        public string title { get; set; }
        public string network { get; set; }
    }

}
