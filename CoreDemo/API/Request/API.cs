using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreDemo.API.Request
{
    class API
    {
        private HttpClient httpClient = new HttpClient();
        private string URI = "https://api.publicapis.org";

        public async Task<string> testrequest()
        {
            var Builder = new System.UriBuilder($"{URI}/entries?category=animals&https=true");
            var response = await httpClient.GetAsync(Builder.Uri);
            var context = await response.Content.ReadAsStringAsync();
            return context;
        }
    }
}
