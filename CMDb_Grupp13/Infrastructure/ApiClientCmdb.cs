using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Infrastructure
{

    public class ApiClientCmdb : IApiClientCmdb
    {
        private readonly HttpClient client = new HttpClient();

        public async Task<CmdbDto> GetLikeDislikeAsync<CmdbDto>(string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            try
            {
                using var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<CmdbDto>(responseJson);
                    return data;
                }
                if (response.StatusCode == HttpStatusCode.TooManyRequests)
                {

                    throw new Exception("För många anrop mot api");
                }
                throw new Exception("Felaktigt api-anrop");

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CmdbDto> GetSingleMovieAsync<CmdbDto>(string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            try
            {
                using var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<CmdbDto>(responseJson);
                    return data;
                }
                if (response.StatusCode == HttpStatusCode.TooManyRequests)
                {

                    throw new Exception("För många anrop mot api");
                }
                throw new Exception("Felaktigt api-anrop");

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> GetTopListAsync<T>(string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            try
            {
                using var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<T>(responseJson);
                    return data;
                }
                if (response.StatusCode == HttpStatusCode.TooManyRequests)
                {

                    throw new Exception("För många anrop mot api");
                }
                throw new Exception("Felaktigt api-anrop");

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
