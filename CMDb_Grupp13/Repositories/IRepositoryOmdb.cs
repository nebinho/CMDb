using CMDb_Grupp13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Repositories
{
    public interface IRepositoryOmdb
    {
        /// <summary>
        /// Retrieves a search
        /// </summary>
        /// <returns></returns>
        Task<SearchDto> GetSearchAsync(string searchString);
        Task<IndexDto> GetMovieInformationAsync(string imdbID);
        Task<DetailsDto> GetMovieDetailsAsync(string imdbID);
    }
}
