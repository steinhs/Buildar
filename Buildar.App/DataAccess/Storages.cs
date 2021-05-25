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
    public class Storages
    {
        readonly HttpClient _httpClient = new HttpClient();
        // TODO: Make sure to change the port number to the port your API is using
        static readonly Uri storagesBaseUri = new Uri("http://localhost:45283/api/Storages");

        public async Task<Storage[]> GetStoragesAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(storagesBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Storage[] storages = JsonConvert.DeserializeObject<Storage[]>(json);

            return storages;
        }
    }
}
