using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FunTour.Models;
using System.Data.Entity;
using FunTour.Controllers;

namespace FunTour.Controllers
{
    public class PostController : Controller
    {
      
        private ApplicationDbContext _context;
        public PostController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpGet]
        public ActionResult JokePost()
        {
           return View();
        }
      
        [HttpPost]
        [Authorize]
        public ActionResult JokePost(Posts p)
        {
                p.email = User.Identity.Name;
                _context.post.Add(p);
                _context.SaveChanges();
           
            return RedirectToAction("Getpost");
        }
        [Authorize]
        public ActionResult Getpost(Posts p)
        {
           
                var post = _context.post.ToList();
                return View(post);
        }

        public ActionResult Mypost(Posts p)
        {
            var post = _context.post.ToList();
            return View(post);

        }


    }
}