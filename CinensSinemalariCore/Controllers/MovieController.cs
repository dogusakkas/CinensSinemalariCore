﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.Controllers
{
    
    public class MovieController : Controller
    {
        MovieManager mm = new MovieManager(new EfMovieRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieDetails()
        {
            return View();
        }
    }
}
