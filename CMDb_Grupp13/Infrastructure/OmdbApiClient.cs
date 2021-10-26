﻿using CMDb_Grupp13.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Infrastructure
{
    public class OmdbApiClient : IApiClient
    {
        private readonly HttpClient client = new HttpClient();

        async Task<SearchDto> IApiClient.GetAsync<SearchDtoT>(string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            try
            {
                using var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<SearchDto>(responseJson);
                    return data;
                }

                throw new Exception("Kunde inte etablera en kontakt med API:t");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
