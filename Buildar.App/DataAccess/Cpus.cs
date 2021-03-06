using Buildar.Model.Parts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Buildar.App.DataAccess
{
    public class Cpus
    {
        readonly HttpClient _httpClient = new HttpClient();
        // TODO: Make sure to change the port number to the port your API is using
        static readonly Uri cpusBaseUri = new Uri("http://localhost:45283/api/Cpus");

        public async Task<Cpu[]> GetCpusAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(cpusBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Cpu[] cpus = JsonConvert.DeserializeObject<Cpu[]>(json);

            return cpus;
        }


    }
}
