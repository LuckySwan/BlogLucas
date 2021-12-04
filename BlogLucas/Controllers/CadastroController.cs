using BlogLucas.Models;
using BlogLucas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogLucas.Controllers
{
    public class CadastroController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Cadastro
        public ActionResult Index()
        {
            var cadastros = _context.Cadastros;
            return View(cadastros);
        }

        // GET: Cadastro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cadastro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cadastro/Create
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

        // GET: Cadastro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cadastro/Edit/5
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
        [HttpPost]
        public ActionResult Save(CadastroViewModel cadastroViewModel)
        {
            int res = 0;

            var cadastro = new Cadastro
            {
                Id = cadastroViewModel.Id,
                Nome = cadastroViewModel.Name,
                Endereco = cadastroViewModel.Endereco,
                
                DateCreated = DateTime.Now

            };

            if (cadastro.Id == 0)
            {
                cadastro.DateCreated = DateTime.Now;

                _context.Cadastro.Add(cadastro);
                res = _context.SaveChanges();
            }

            else
               
            {
               
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");

        }

        // GET: Cadastro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cadastro/Delete/5
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
