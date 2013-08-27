using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoderwallLib
{
    public class CoderwallContext
    {
        private readonly HttpClient _client;

        public CoderwallContext()
        {
            _client = new HttpClient
                {
                    BaseAddress = new Uri("https://coderwall.com/")
                };
        }

        public string SayHello(string name)
        {
            return string.Format("Hello {0}", name);
        }

        public async Task<Profile> GetProfileAsync(string username)
        {
            try
            {
                string uri = string.Format("{0}.json", username);
                var response = await _client.GetAsync(uri);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
               return JsonConvert.DeserializeObject<Profile>(content);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}

