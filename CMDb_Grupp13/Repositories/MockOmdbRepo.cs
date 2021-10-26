using CMDb_Grupp13.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Repositories
{
    public class MockOmdbRepo : IRepositoryOmdb
    {
        private readonly string basePath;

        public MockOmdbRepo(IWebHostEnvironment environment)
        {
            basePath = $@"{ environment.ContentRootPath}\Mock\";
        }

        private SearchDto GetTestData<SearchDto>(string testfile)
        {
            var path = $"{basePath}{testfile}";
            string data = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<SearchDto>(data);
        }


        public async Task<SearchDto> GetSearchAsync()
        {
            await Task.Delay(0);
            return GetTestData<SearchDto>("search.json");
        }
    }
}
