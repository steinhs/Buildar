using System;
using Buildar.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Buildar.App.DataAccess
{
    public class Builds
    {
        readonly HttpClient _httpClient = new HttpClient();

        static readonly Uri buildsBaseUri = new Uri("http://localhost:45283/api/Builds");

       

        public async Task<Build[]> GetBuildsAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(buildsBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Build[] builds = JsonConvert.DeserializeObject<Build[]>(json);

            return builds;
        }

        internal async Task<bool> AddBuildAsync(Build build)
        {
            string json = JsonConvert.SerializeObject(build);
            HttpResponseMessage result = await _httpClient.PostAsync(buildsBaseUri, new StringContent(json, Encoding.UTF8, "application/json"));

            if (result.IsSuccessStatusCode)
            {
                json = await result.Content.ReadAsStringAsync();
                var returnedBuild = JsonConvert.DeserializeObject<Build>(json);
                build.Id = returnedBuild.Id;

                return true;
            }
            else
            {
                return false;
            }
        }

        internal async Task<bool> DeleteBuildAsync(Build build)
        {
            HttpResponseMessage result = await _httpClient.DeleteAsync(new Uri(buildsBaseUri, "builds/" + build.Id.ToString()));
            return result.IsSuccessStatusCode;
        }

        /*internal async Task<bool> UpdateBuildAsync(Build build)
        {
            HttpResponseMessage result = await _httpClient.UpdateAsync(new Uri());
            return result.IsSuccessStatusCode;
        }*/

    }
}
