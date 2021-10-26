using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Models.ViewModels
{
    public class SearchViewModel
    {
        private readonly SearchDto search;

        public string SelectedMovie { get; set; }

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

        public SearchViewModel(SearchDto search)
        {
            this.search = search;
        }

        public SearchViewModel()
        {

        }
    }
}
