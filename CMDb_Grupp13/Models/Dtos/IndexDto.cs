using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Models
{
    public class IndexDto
    {
        public string ImdbID { get; set; }
        public string Title { get; set; }
        public string PlotShort { get; set; }
        public string PlotLong { get; set; }
        public IEnumerable<RatingsDto> Ratings { get; set; }
    }
}
