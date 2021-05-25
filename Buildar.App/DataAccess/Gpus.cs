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
    public class Gpus
    {
        readonly HttpClient _httpClient = new HttpClient();
        // TODO: Make sure to change the port number to the port your API is using
        static readonly Uri gpusBaseUri = new Uri("http://localhost:45283/api/Gpus");

        public async Task<Gpu[]> GetGpusAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(gpusBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Gpu[] gpus = JsonConvert.DeserializeObject<Gpu[]>(json);

            return gpus;
        }
    }
}
