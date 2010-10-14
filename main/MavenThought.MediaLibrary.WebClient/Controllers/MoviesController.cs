﻿using System;
using System.Linq;
using System.Web.Mvc;
using MavenThought.MediaLibrary.Domain;

namespace MavenThought.MediaLibrary.WebClient.Controllers
{
    /// <summary>
    /// Controller for movies
    /// </summary>
    public class MoviesController : Controller
    {
        /// <summary>
        /// Library instance
        /// </summary>
        private readonly IMediaLibrary _library;

        /// <summary>
        /// Initializes the controller
        /// </summary>
        /// <param name="library">Library to use</param>
        public MoviesController(IMediaLibrary library)
        {
            _library = library;
        }

        /// <summary>
        /// Gets the list of movies GET : /Movies/
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View(this._library.Contents.ToList());
        }

        /// <summary>
        /// Gets the form to add movies GET : /Movies/Create
        /// </summary>
        /// <returns>The view with the form</returns>
        public ActionResult Create()
        {
            return View();
        }
    }
}
