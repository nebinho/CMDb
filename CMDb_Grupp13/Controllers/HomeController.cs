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
        private IRepositoryCmdb cmdbRepo;
        private IRepositoryOmdb omdbRepo;


        public HomeController(IRepositoryCmdb cmdbRepo, IRepositoryOmdb omdbRepo)
        {
            this.cmdbRepo = cmdbRepo;
            this.omdbRepo = omdbRepo;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var search = await omdbRepo.GetSearchAsync();
                var topList = await cmdbRepo.GetTopListAsync();

                var model = new HomeViewModel(topList, search);

                return View(model);

            }
            catch (Exception)
            {
                var model = new HomeViewModel();
                ModelState.AddModelError(string.Empty, "Kunde inte få kontakt med API:t");
                return View(model);
                throw;
            }
        }

    }
}
