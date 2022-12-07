﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_codefirstproject.Models;

namespace Movie_codefirstproject.Controllers
{
    public class MovieController : Controller
    {
        MovieContext mm = new MovieContext();
        // GET: Movie
        public ActionResult Index()
        {

            return View(mm.Movies.ToList());
        }

        public ActionResult GetMovieDetails()
        {
            List<Movie> movies = mm.Movies.ToList();
            return View(movies);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(Movie movie)
        {
            mm.Movies.Add(movie);
            mm.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movie ms = mm.Movies.Find(id);
            return View(ms);
        }

        //post of edit
        public ActionResult Edit(Movie m)
        {
            Movie ms = mm.Movies.Find(m.Mid);//getting before update -data
            ms.MovieName = m.MovieName;
            ms.DateofRelease = m.DateofRelease;
            mm.SaveChanges();
            return RedirectToAction("Index");
        }

        //delete 
        public ActionResult Delete(int id)
        {
            Movie m = mm.Movies.Find(id);
            mm.Movies.Remove(m);
            mm.SaveChanges();
            return RedirectToAction("Index");
        }
        //details
        public ActionResult Details(int id)
        {
            Movie md = mm.Movies.Find(id);
            return View(md);
        }
        

    }
}