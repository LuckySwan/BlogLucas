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
            var posts = _context.Posts;
            return View(posts);
        }
        public ActionResult Random()
        {

            var post = new Post { Title = "Post Exemplo", Body = "Corpo da mensagem", DateCreated = DateTime.Now };
            ViewBag.Post = post;


            return View(post);
        }
        [HttpPost]
        public ActionResult Save(Post post)
        {
            int res = 0;
            if (post.Id == 0)
            {
                post.DateCreated = DateTime.Now;
                _context.Posts.Add(post);
                res = _context.SaveChanges();
            }

            else
            {
                var postToUpdate = _context.Posts.SingleOrDefault(p => p.Id == post.Id);
                postToUpdate.Title = post.Title;
                postToUpdate.Body = post.Body;
                postToUpdate.DateUpdated = DateTime.Now;

                // _context.Posts.Add(postToUpdate);
                res = _context.SaveChanges();

            }
            if (res > 0)
            {
                //return new HttpStatusCodeResult(200);
                return RedirectToAction("Index");
            }


            //if (!ModelState.IsValid)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
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
            var postToUpdate = _context.Posts.SingleOrDefault(p => p.Id == id);
            if (postToUpdate == null)
            {
                return HttpNotFound();
            }
            return View(postToUpdate);
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
            var postToDelete = _context.Posts.SingleOrDefault(p => p.Id == id);
            if (postToDelete == null)
            {
                return HttpNotFound();
            }
            return View(postToDelete);
        }
            
        

        // POST: Posts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var postToDelete = _context.Posts.SingleOrDefault(p => p.Id == id);
            if (postToDelete == null)
            {
                return HttpNotFound();
            }
            _context.Posts.Remove(postToDelete);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
