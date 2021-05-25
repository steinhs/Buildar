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
    public class Cases
    {
        readonly HttpClient _httpClient = new HttpClient();
        // TODO: Make sure to change the port number to the port your API is using
        static readonly Uri casesBaseUri = new Uri("http://localhost:45283/api/Cases");

        public async Task<Case[]> GetCasesAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(casesBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Case[] cases = JsonConvert.DeserializeObject<Case[]>(json);

            return cases;
        }
    }
}
