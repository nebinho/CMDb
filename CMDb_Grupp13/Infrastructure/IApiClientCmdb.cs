using System;
using System.Collections.Generic;
using System.Linq;
using CMDb_Grupp13.Models;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Infrastructure
{
    public interface IApiClientCmdb
    {
        Task<T> GetAsync<T>(string endpoint);
        

    }
}
