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
            var movieLikesDislikes = await cmdbRepo.GetSingleMovieAsync(imdbID);

            var model = new DetailsViewModel
            {
                Movie = movie,
                Info = movieLikesDislikes
            };

            return View(model);
        }

        //[HttpGet]
        //public async Task<IActionResult> LikeDislike(string imdbID, string action)
        //{

        //        var like = await cmdbRepo.GetLikeDislikeAsync(imdbID, action);
        //    var model = new DetailsViewModel
        //    {
        //        Info = like
        //    };

        //    return View(model);
        //}
    }
}
