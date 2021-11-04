using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Models.ViewModels
{
    public class DetailsViewModel
    {
        public MovieDetailsDto Movie { get; set; }
        public CmdbDto Info { get; set; }
    }
}
