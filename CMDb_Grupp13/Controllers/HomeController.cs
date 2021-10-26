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
        private IRepository cmdbRepo;


        public HomeController(IRepository cmdbRepo)
        {
            this.cmdbRepo = cmdbRepo;
        }

        public async Task<IActionResult> Index()
        {
            var topList = await cmdbRepo.GetTopListAsync();
            var model = new TopListViewModel(topList);

            return View(model);
        }

    }
}
