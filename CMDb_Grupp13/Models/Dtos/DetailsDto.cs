using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Models
{
    public class DetailsDto
    {
        public string ImdbID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string PlotLong { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Country { get; set; }


        public IEnumerable<RatingsDto> Ratings { get; set; }
    }
}
