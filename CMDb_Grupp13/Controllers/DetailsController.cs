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
        private readonly IRepositoryCmdb cmdbRepo;
        private readonly IRepositoryOmdb omdbRepo;

        public DetailsController(IRepositoryCmdb cmdbRepo, IRepositoryOmdb omdbRepo)
        {
            this.cmdbRepo = cmdbRepo;
            this.omdbRepo = omdbRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string imdbID)
        {
            try
            {
                var task1 = omdbRepo.GetMovieAsync(imdbID);
                var task2 = cmdbRepo.GetSingleMovieAsync(imdbID);

                await Task.WhenAll(task1, task2);

                var movie = await task1;
                var movieInfo = await task2;

                var model = new DetailsViewModel
                {
                    Movie = movie,
                    Info = movieInfo
                };

                return View(model);
            }
            catch (Exception)
            {
                var model = new HomeViewModel();
                ModelState.AddModelError(string.Empty, "Kunde inte hämta detaljer om filmen");
                return View(model);
                throw;
            }
        }
    }
}
