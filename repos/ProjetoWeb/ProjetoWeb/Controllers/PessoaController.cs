using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoWeb.Models;

namespace ProjetoWeb.Controllers
{
    public class PessoaController : Controller
    {
        public Documentos Documentos { get; private set; }

        public IActionResult Index()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa {
                Nome = "Caio Henrique",
                DataNascimento = new DateTime(1992,06,26)
                
            });

            pessoas.Add(new Pessoa
            {
                Nome = "Irineu",
                DataNascimento = new DateTime(1500,06,01)
            });

            return View(pessoas);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Pessoa formCollection)
        {
            var form = formCollection;


            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            Documentos = new Documentos()

            {
                rg = "123.456",
                cpf = "456.123",
                passaport = "BR-07"

            };

            IList<Familia> familias = new List<Familia>();
            familias.Add(new Familia
            {
                GrauParentesco = GrauParentesco.Mae,
                nome = "lucila",
                idade = 60

            });
            familias.Add(new Familia
            {
                GrauParentesco = GrauParentesco.Irmao,
                nome = "Amarilis",
                idade = 60

            });
            Pessoa pessoa = new Pessoa
            {
                Nome = "Caio Henrique",
                DataNascimento = new DateTime(1992, 06, 26),
                Familias = familias,
                Documentos = Documentos
            };

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Edit(Pessoa Pessoa)
        {
            return RedirectToAction("Index");
        }
    }
}