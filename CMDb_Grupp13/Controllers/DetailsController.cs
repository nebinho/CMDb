using CMDb_Grupp13.Models.ViewModels;
using CMDb_Grupp13.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Controllers
{
    public class DetailsController : Controller
    {
        private IRepositoryCmdb cmdbRepo;
        private IRepositoryOmdb omdbRepo;


        public DetailsController(IRepositoryCmdb cmdbRepo, IRepositoryOmdb omdbRepo)
        {
            this.cmdbRepo = cmdbRepo;
            this.omdbRepo = omdbRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string imdbID)
        {
            var movie = await omdbRepo.GetMovieAsync(imdbID);
            var movieInfo = await cmdbRepo.GetSingleMovieAsync(imdbID);

            var model = new DetailsViewModel
            {
                Movie = movie,
                Info = movieInfo
            };

           
            return View(model);
        }

    }
}
