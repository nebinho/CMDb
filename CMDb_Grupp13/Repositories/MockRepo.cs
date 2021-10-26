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
    //public class MockRepo : IRepository
    //{
    //    //private readonly string basePath;


    //    //public MockRepo(IWebHostEnvironment environment)
    //    //{
    //    //    basePath = $@"{ environment.ContentRootPath}\Mock\";
    //    //}

    //    //public async Task<TopListDto> GetTopListAsync()
    //    //{
    //    //    await Task.Delay(0);
    //    //    return GetTestData<TopListDto>("Test.json");
    //    //}

    //    //private T GetTestData<T>(string testfile)
    //    //{
    //    //    var path = $"{basePath}{testfile}";
    //    //    string data = File.ReadAllText(path);
    //    //    return JsonConvert.DeserializeObject<T>(data);
    //    //}

    //    public TopListDto GetTopList()
    //    {
    //        return null;
    //    }
    //}
}
