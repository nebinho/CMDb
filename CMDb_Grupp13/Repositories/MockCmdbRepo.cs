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

        public async Task<IEnumerable<CmdbDto>> GetTopListAsync()    
        {
            await Task.Delay(0);
            return GetTestData<IEnumerable<CmdbDto>>("toplist.json");
        }

        public Task<CmdbDto> GetSingleMovieAsync(string imdbID)
        {
            throw new NotImplementedException();
        }

        public Task<CmdbDto> GetLikeDislikeAsync(string imdbID, string action)
        {
            throw new NotImplementedException();
        }
    }
}
