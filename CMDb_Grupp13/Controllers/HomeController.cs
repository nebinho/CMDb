﻿using CMDb_Grupp13.Models;
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
        private IRepository omdbRepo;

        public HomeController(IRepository omdbRepo)
        {
            this.omdbRepo = omdbRepo;
        }
        public async Task<IActionResult> Index()
        {
            var search = await omdbRepo.GetSearchAsync();
            var model = new SearchViewModel(search);

            return View(model);
        }

    }
}
