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
    public class Motherboards
    {
        readonly HttpClient _httpClient = new HttpClient();
        // TODO: Make sure to change the port number to the port your API is using
        static readonly Uri motherboardsBaseUri = new Uri("http://localhost:45283/api/Motherboards");

        public async Task<Motherboard[]> GetMotherboardsAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(motherboardsBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Motherboard[] motherboards = JsonConvert.DeserializeObject<Motherboard[]>(json);

            return motherboards;
        }
    }
}
