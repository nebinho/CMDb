using CMDb_Grupp13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Repositories
{
    public interface IRepositoryCmdb
    {
        Task<IEnumerable<CmdbDto>> GetTopListAsync();
        Task<CmdbDto> GetSingleMovieAsync(string imdbID);
        Task<CmdbDto> GetLikeDislikeAsync(string imdbID, string action);

    }
}
