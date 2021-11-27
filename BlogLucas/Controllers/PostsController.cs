using BlogLucas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BlogLucas.Controllers
{
    public class PostsController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Posts
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Random()
        {
            
           var post = new Post { Title = "Post Exemplo", Body = "Corpo da mensagem", DateCreated = DateTime.Now };

            
            return View(post);
        }

        public ActionResult Save(Post post)

        {
            post.DateCreated = DateTime.Now;
            _context.Posts.Add(post);
            var res = _context.SaveChanges();

            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            

            

            if (res > 0)
            {
                //return new HttpStatusCodeResult(200);
                return RedirectToAction("Index");
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        public ActionResult NewPost()
        {
            return View();
        }

        // GET: Posts/Details/5
        public ActionResult Details(int id)
        {
            var post = _context.Posts.SingleOrDefault(p => p.Id == id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Posts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Posts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
