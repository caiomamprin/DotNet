using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Domain;
using Loja.SQL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Loja.Web.Controllers
{
    public class DepartamentoController : Controller
    {

        private readonly LojaContext _context;

        public DepartamentoController(LojaContext context)
        {
            _context = context;
        }

        // GET: Departamento
        public ActionResult Index()
        {
            var listaDeDepartamentos = _context.Departamentos.ToList();
            return View(listaDeDepartamentos);
        }

        // GET: Departamento/Details/5
        public ActionResult Details(int id)
        {

            var departamento = _context.Departamentos.FirstOrDefault(m => m.Id == id);

            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }

        // GET: Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id","Nome")]
        Departamento departamento)
        {
           
                try
                {
                    if (ModelState.IsValid) { 

                        _context.Add(departamento);
                        _context.SaveChanges();
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch
                {
                    return View();
                }
                return View(departamento);
        }

        // GET: Departamento/Edit/5
        public ActionResult Edit(int id)
        {

            var departamento = _context.Departamentos.FirstOrDefault(m => m.Id == id);

            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }


        // POST: Departamento/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Nome")] Departamento departamento)
        {

            //verifico se o id é o mesmo que tenho no banco
            if (id != departamento.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {


                try
                {
                    _context.Update(departamento);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartamentoExists(departamento.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }

                }

            }
            return View(departamento);
        }


        // GET: Departamento/Delete/5
        public ActionResult Delete(int id)
        {
            var departamento = _context.Departamentos.FirstOrDefault(m => m.Id == id);

            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }

        // POST: Departamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var departamento = _context.Departamentos.Find(id);
            _context.Departamentos.Remove(departamento);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartamentoExists(int id)
        {
            return _context.Departamentos.Any(e => e.Id == id);
        }
    }
}
