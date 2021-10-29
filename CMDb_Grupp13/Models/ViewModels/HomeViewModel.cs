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
        public IEnumerable<MovieSearchDto> Search { get; set; }
        public string SearchMovie { get; set; }
        public string SelectedMovie { get; set; }
        public List<TopListDto> TopList { get; set; }
        public string ImdbID { get; set; }
        public List<MovieDetailsDto> Movies { get; set; }
    }

}
