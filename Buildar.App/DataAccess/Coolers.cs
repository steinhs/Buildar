using Buildar.Model.Parts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace Buildar.App.DataAccess
{
    public class Coolers
    {
        readonly HttpClient _httpClient = new HttpClient();
        // TODO: Make sure to change the port number to the port your API is using
        static readonly Uri coolersBaseUri = new Uri("http://localhost:45283/api/Coolers");

        public async Task<Cooler[]> GetCoolersAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(coolersBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Cooler[] coolers = JsonConvert.DeserializeObject<Cooler[]>(json);

            return coolers;
        }
    }
}
