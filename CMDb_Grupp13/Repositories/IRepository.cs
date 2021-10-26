using CMDb_Grupp13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Repositories
{
    public interface IRepository
    {
        
       // Task<IEnumerable<TopListDto>> GetSearch();
       Task<IEnumerable<TopListDto>> GetTopListAsync();
        /// <summary>
        /// Retrieves a search
        /// </summary>
        /// <returns></returns>
        Task<SearchDto> GetSearchAsync();
    }
}
