using System;
using System.Web.Http;
using Signa.Common.ExceptionHelper;
using SignaLibrary40.Library;
using WAPendencia.BE;

namespace WAPendencia
{
    public class PendenciaController : ApiController
    {
        PendenciaBo bo = new PendenciaBo();

        [HttpGet]
        public object RelatorioComprovacaoPassagem([FromUri] int pendenciaId)
        {
            try
            {
                return new
                {
                    comprovacaoPassagemLista = bo.RelatorioComprovacaoPassagem(pendenciaId),
                    retorno = 0
                };
            }
            catch (SigRNException ex)
            {
                return ExceptionLibrary.tratarRNException(ex.Message);
            }
            catch (Exception ex)
            {
                return ExceptionLibrary.tratarLogException("RelatorioComprovacaoPassagem",
                    "Problemas ao buscar relatório de comprovação de passagem. Entre em contato com a Signa", ex);
            }
        }

        [HttpPost]
        public object Gravar([FromBody] PendenciaBe pendencia)
        {
            try
            {
                return new
                {
                    pendencia = bo.Gravar(pendencia),
                    retorno = 0
                };
            }
            catch (SigRNException ex)
            {
                return ExceptionLibrary.tratarRNException(ex.Message);
            }
            catch (Exception ex)
            {
                return ExceptionLibrary.tratarLogException("Gravar", "Problemas ao gravar pendências. Entre em contato com a Signa", ex);
            }
        }

        [HttpGet]
        [Route ("Consultar")]
        public object Consultar([FromUri] int pendenciaId)
        {
            try
            {
                return new
                {
                    pendencia = bo.Consultar(pendenciaId),
                    retorno = 0
                };
            }
            catch (SigRNException ex)
            {
                return ExceptionLibrary.tratarRNException(ex.Message);
            }
            catch (Exception ex)
            {
                return ExceptionLibrary.tratarLogException("Consultar", "Problemas ao consultar pendência. Entre em contato com a Signa", ex);
            }
        }
    }
}
