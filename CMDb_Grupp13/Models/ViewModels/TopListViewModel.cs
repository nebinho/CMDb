using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Models.ViewModels
{
    public class TopListViewModel
    {

        private IEnumerable<TopListDto> TopList { get; set; }
        public string ImdbID { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfDislikes { get; set; }

        public int TopRatedMovie()
        {
            int topRating = TopList.Max(x => x.numberOfLikes);
            return topRating;
        }

        public TopListViewModel(IEnumerable<TopListDto> topList)
        {
            TopList = topList;
            var query = TopList
                .Where(x => x.numberOfLikes == TopRatedMovie())
                .FirstOrDefault();
            NumberOfLikes = query.numberOfLikes;
            ImdbID = query.imdbID;

        }
    }
}
