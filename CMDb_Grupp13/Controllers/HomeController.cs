using CMDb_Grupp13.Models;
using CMDb_Grupp13.Models.ViewModels;
using CMDb_Grupp13.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoryCmdb cmdbRepo;
        private readonly IRepositoryOmdb omdbRepo;

        public HomeController(IRepositoryCmdb cmdbRepo, IRepositoryOmdb omdbRepo)
        {
            this.cmdbRepo = cmdbRepo;
            this.omdbRepo = omdbRepo;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var task1 = cmdbRepo.GetTopListAsync(4);
                var topList = await task1;

                var tasks = topList.Select(m => omdbRepo.GetMovieAsync(m.imdbID));
                var movieDetails = await Task.WhenAll(tasks);

                var model = new HomeViewModel
                {
                    TopList = topList.ToList(),
                    MovieDetails = movieDetails.ToList()
                };

                return View(model);
            }
            catch (Exception)
            {
                var model = new HomeViewModel();
                ModelState.AddModelError(string.Empty, "Kunde inte hämta topplistan");
                return View(model);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Search(string searchinput)
        {
            try
            {             
                var task1 = cmdbRepo.GetTopListAsync(4);
                var task2 = omdbRepo.GetSearchAsync(searchinput);

                await Task.WhenAll(task1, task2);

                var topList = await task1;
                var searchResult = await task2;

                var tasks1 = topList.Select(m => omdbRepo.GetMovieAsync(m.imdbID));
                var movieDetails = await Task.WhenAll(tasks1);

                if (searchResult.Search == null)
                {
                    var mdl = new HomeViewModel
                    {
                        TopList = topList.ToList(),
                        MovieDetails = movieDetails.ToList()
                    };
                    ModelState.AddModelError("validation", "Hittade inte filmen du sökte efter, prova gärna med en annan film");
                    return View("Index", mdl);
                }

                var tasks2 = searchResult.Search.Select(s => omdbRepo.GetMovieAsync(s.imdbID));
                var searchList = await Task.WhenAll(tasks2);

                var model = new HomeViewModel
                {
                    TopList = topList.ToList(),
                    MovieDetails = movieDetails.ToList(),
                    SearchResult = searchResult.Search,
                    SearchList = searchList.ToList()
                };

                return View("Index", model);
            }
            catch (Exception)
            {
                var model = new HomeViewModel();
                ModelState.AddModelError(string.Empty, "Hittade inte filmen du sökte efter, prova gärna med en annan");
                return View(model);
                throw;
            }
        }
    }
}
