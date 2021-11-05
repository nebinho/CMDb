using CMDb_Grupp13.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace CMDb_Grupp13.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<MovieSearchDto> SearchResult { get; set; }
        public List<CmdbDto> TopList { get; set; }
        public List<MovieDetailsDto> MovieDetails { get; set; }
        public List<MovieDetailsDto> SearchList { get; set; }
    }
}
