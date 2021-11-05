using CMDb_Grupp13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Repositories
{
    public interface IRepositoryCmdb
    {
        Task<IEnumerable<CmdbDto>> GetTopListAsync(int numberOfMovies);
        Task<CmdbDto> GetSingleMovieAsync(string imdbID);
        

    }
}
