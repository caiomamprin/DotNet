using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NovaApi.Repositorio;
using NovoApi.Models;

namespace NovaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalestranteController : ControllerBase
    {
        private PalestranteRepositorio  _palestranteRepositorio;

        public PalestranteController()
        {
            _palestranteRepositorio = new PalestranteRepositorio();
        }

  


        // GET: api/Palestrante
        [HttpGet]
        public IEnumerable<Palestrante> Get()
        {
            return _palestranteRepositorio.RetornaTudo();
        }

        // GET: api/Palestrante/5
        [HttpGet("{id}", Name = "Get")]
        public Palestrante Get(int id)
        {
            return _palestranteRepositorio.RetornaById(id);
        }

        // POST: api/Palestrante
        [HttpPost]
        public Palestrante Post([FromBody] Palestrante palestrante)
        {
            return _palestranteRepositorio.AdicionarPalestrante(palestrante);
        }

        // PUT: api/Palestrante/5
        [HttpPut("{id}")]
        public Palestrante Put(int id, [FromBody] Palestrante palestrante)
        {
            palestrante.Id = id;

            return _palestranteRepositorio.AlteraPalestrante(palestrante);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IList<Palestrante> Delete(int id)
        {
            return _palestranteRepositorio.ExcluiPalestrante(id);

        }
    }
}
