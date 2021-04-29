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
        static readonly Uri cpusBaseUri = new Uri("https://localhost:44368/api/Cpus");

        public async Task<Cpu[]> GetCpusAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(cpusBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Cpu[] cpus = JsonConvert.DeserializeObject<Cpu[]>(json);

            return cpus;
        }

        internal async Task<bool> AddCpuAsync(Cpu cpu)
        {
            string json = JsonConvert.SerializeObject(cpu);
            HttpResponseMessage result = await _httpClient.PostAsync(cpusBaseUri, new StringContent(json, Encoding.UTF8, "application/json"));

            if (result.IsSuccessStatusCode)
            {
                json = await result.Content.ReadAsStringAsync();
                var returnedCpu = JsonConvert.DeserializeObject<Cpu>(json);
                cpu.CpuId = returnedCpu.CpuId;

                return true;
            }
            else
                return false;
        }

        internal async Task<bool> DeleteCpuAsync(Cpu cpu)
        {
            HttpResponseMessage result = await _httpClient.DeleteAsync(new Uri(cpusBaseUri, "cpus/" + cpu.CpuId.ToString()));
            return result.IsSuccessStatusCode;
        }
    }
}
