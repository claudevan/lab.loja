using LabAspMVC.Application.ViewModels.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LabAspMVC.Application.Controllers
{
    public class ClienteController : Controller
    {
        private static List<ClienteVM> clientes = new List<ClienteVM>()
        {
            new ClienteVM() {Id= 1, CPF = "123.456.789-98", DataNascimento=new DateTime(1988, 07, 14), Nome = "Cliente 1" },
            new ClienteVM() {Id= 2, CPF = "123.456.789-98", DataNascimento=new DateTime(1988, 07, 14), Nome = "Cliente 2" },
            new ClienteVM() {Id= 3, CPF = "123.456.789-98", DataNascimento=new DateTime(1988, 07, 14), Nome = "Cliente 3" },
            new ClienteVM() {Id= 4, CPF = "123.456.789-98", DataNascimento=new DateTime(1988, 07, 14), Nome = "Cliente 4" },
            new ClienteVM() {Id= 5, CPF = "123.456.789-98", DataNascimento=new DateTime(1988, 07, 14), Nome = "Cliente 5" }
        };

        // GET: Cliente
        public ActionResult Index()
        {
            return View(clientes);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var cliente = clientes.Where(w => w.Id == id).FirstOrDefault();
            if (cliente == null)
            {
                return HttpNotFound();
            }

            return View(cliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Nome,CPF,DataNascimento,Endereco")] ClienteVM clienteVM)
        {
            if (ModelState.IsValid)
            {
                clienteVM.Id = clientes.Max(m => m.Id) + 1;
                clientes.Add(clienteVM);

                return RedirectToAction("Index");
            }

            return View(clienteVM);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var cliente = clientes.Where(w => w.Id == id).FirstOrDefault();
            if (cliente == null)
            {
                return HttpNotFound();
            }

            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Nome,CPF,DataNascimento,Endereco")] ClienteVM clienteVM)
        {
            if (ModelState.IsValid)
            {
                clientes.Add(clienteVM);
                return RedirectToAction("Index");
            }
            return View(clienteVM);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var cliente = clientes.FirstOrDefault(w => w.Id == id);
            if (cliente == null)
            {
                return HttpNotFound();
            }

            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var cliente = clientes.FirstOrDefault(w => w.Id == id);
            clientes.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
