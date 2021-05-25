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
    public class Memorys
    {
        readonly HttpClient _httpClient = new HttpClient();
        // TODO: Make sure to change the port number to the port your API is using
        static readonly Uri memorysBaseUri = new Uri("http://localhost:45283/api/Memorys");

        public async Task<Memory[]> GetMemorysAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(memorysBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Memory[] memorys = JsonConvert.DeserializeObject<Memory[]>(json);

            return memorys;
        }

    }
}
