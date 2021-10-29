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
    public class MockCmdbRepo : IRepositoryCmdb
    {
        private readonly string basePath;

        public MockCmdbRepo(IWebHostEnvironment environment)
        {
            basePath = $@"{ environment.ContentRootPath}\Mock\";
        }

        private T GetTestData<T>(string testfile)
        {
            var path = $"{basePath}{testfile}";
            string data = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(data);
        }

        public async Task<IEnumerable<TopListDto>> GetTopListAsync()    
        {
            await Task.Delay(0);
            return GetTestData<IEnumerable<TopListDto>>("toplist.json");
        }
    }
}
