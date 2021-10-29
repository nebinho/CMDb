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
        private readonly SearchDto search;
        private readonly MovieSearchDto movie;
        private readonly DetailsDto details;
        



        public string SelectedMovie { get; set; }
        public string SearchMovie { get; set; }
        private IEnumerable<TopListDto> TopList { get; set; }
        private IEnumerable<IndexDto> MovieInformation { get; set; }
        public string ImdbID { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfDislikes { get; set; }
        public string Title { get; set; }

    

        public IEnumerable<SelectListItem> Search
        {
            #region Fyller cmbbox med movies
            get
            {
                if (search.Search != null)
                {
                    return search.Search.Select(x =>
                   new SelectListItem()
                   {
                       Text = x.Title,
                       Value = x.imdbID

                   });
                }
                return null;
            }
            #endregion
        }

   

        public int TopRatedMovie()
        {
            int topRating = TopList.Max(x => x.NumberOfLikes);
            return topRating;
        }



        public HomeViewModel(IEnumerable<TopListDto> topList, SearchDto search)
        {
            TopList = topList;

            var query = TopList
                .Where(x => x.NumberOfLikes == TopRatedMovie())
                .FirstOrDefault();
            NumberOfLikes = query.NumberOfLikes;
            ImdbID = query.ImdbID;
            
           
 

            this.search = search;

     


        }

        public HomeViewModel()
        {

        }
    }

}
