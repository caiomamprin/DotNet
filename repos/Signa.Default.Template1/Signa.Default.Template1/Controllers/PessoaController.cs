using Signa.Default.Template1.Data.Interface;
using Signa.Default.Template1.Data.Repository;
using Signa.Default.Template1.Filters;
using Signa.Default.Template1.Models;
using Signa.Library.Helpers;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace Signa.Default.Template1.Controllers
{
    //[JwtAuthentication] //só será usado quando for implantado o menu que utiliza jwt
    [ExceptionFilter]
    public class PessoaController : ApiController
    {
        IPessoaRepository _pessoa;

        PessoaController()
        {
            _pessoa = new PessoaRepository();
        }

        [HttpGet]
        [Route("Listar")]
        public IHttpActionResult Listar()
        {
            return Ok(_pessoa.GetAll());
        }

        [HttpGet]
        [Route("Consultar/{id}")]
        public IHttpActionResult Consultar(int id)
        {
            if (id == 0)
            {
                return BadRequest("Informe um id para consulta");
            }

            var pessoa = _pessoa.GetById(id);

            if (pessoa.PessoaId == 0)
            {
                return BadRequest("Pessoa não encontrada");
            }

            return Ok(pessoa);
        }

        [HttpPut]
        [Route("Gravar")]
        public IHttpActionResult Gravar(PessoaModel pessoa)
        {
            if (!ModelState.IsValid)
            {
                HttpRequestMessage Request = new HttpRequestMessage();
                //List<string> lista = ModelState.Values.SelectMany(j => j.Errors).Select(m => m.ErrorMessage).ToList();
                return BadRequest(ModelState);
            }

            if (pessoa.PessoaNome.Count() > 3 && pessoa.PessoaNomeFantasia.Count() > 3)
            {
                throw new SignaRegraNegocioException(0, "Preencha Nome ou Nome Fantasia");
            }

            if (_pessoa.Insert(pessoa))
            {
                return Ok();
            }

            return BadRequest("Pessoa não inserida");
        }

        [HttpPut]
        [Route("Atualizar")]
        public IHttpActionResult Atualizar(PessoaModel pessoa)
        {
            /*if(!ModelState.IsValid)
                return StatusReturn.BadRequest(new { ListaErro = ModelState.Values.SelectMany(x => x.Errors).Select(p => p.ErrorMessage) });
                */
            if (pessoa.PessoaId == 0)
            {
                return BadRequest("Informe id de pessoa válido");
            }

            if (_pessoa.Update(pessoa))
            {
                return Ok();
            }

            return BadRequest("Pessoa não atualizada");

        }

        [HttpDelete]
        [Route("Excluir/{id}")]
        public IHttpActionResult Excluir(int id)
        {
            if (id == 0)
            {
                return BadRequest("Informe um Id para Excluir");
            }

            if (_pessoa.Delete(id))
            {
                return Ok();
            }

            return BadRequest("Id não encontrado.");
        }
    }
}