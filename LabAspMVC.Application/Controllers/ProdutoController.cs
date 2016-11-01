using LabAspMVC.Application.ViewModels.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LabAspMVC.Application.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<ProdutoVM> produtos = new List<ProdutoVM>()
        {
            new ProdutoVM {Id = 1, Descricao = "Produto 1", Titulo = "Titulo 1", Valor = 1 },
            new ProdutoVM {Id = 2, Descricao = "Produto 2", Titulo = "Titulo 2", Valor = 1 },
            new ProdutoVM {Id = 3, Descricao = "Produto 3", Titulo = "Titulo 3", Valor = 1 }
        };

        // GET: Produto
        public ActionResult Index()
        {
            return View(produtos);
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
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

        // GET: Produto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = produtos.Where(w => w.Id == id).FirstOrDefault();
            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(ProdutoVM model)
        {
            if (ModelState.IsValid)
            {
                var produtoBase = produtos.Where(w => w.Id == model.Id).FirstOrDefault();
                var index = produtos.IndexOf(produtoBase);

                produtos[index].Descricao = model.Descricao;
                produtos[index].Titulo = model.Titulo;
                produtos[index].Valor = model.Valor;

                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
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
