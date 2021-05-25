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
    public class Psus
    {
        readonly HttpClient _httpClient = new HttpClient();
        // TODO: Make sure to change the port number to the port your API is using
        static readonly Uri psusBaseUri = new Uri("http://localhost:45283/api/Psus");

        public async Task<Psu[]> GetPsusAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(psusBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Psu[] psus = JsonConvert.DeserializeObject<Psu[]>(json);

            return psus;
        }
    }
}
