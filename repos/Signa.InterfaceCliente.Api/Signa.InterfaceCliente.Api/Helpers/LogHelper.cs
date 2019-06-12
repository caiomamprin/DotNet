using Signa.InterfaceCliente.Api.Data.Repository;
using Signa.Library.Data.Interface;
using Signa.Library.Data.Repository;

namespace Signa.InterfaceCliente.Api.Helpers
{
    public static class LogHelper
    {

        public static void GravaLogMsg(int tipoMsgId, int usuarioId, string texto)
        {

            IHelperRepository _helperRepository = new HelperRepository();
            _helperRepository.GravaLogMsg(RepositoryBase.Connection, tipoMsgId, usuarioId, texto);
        }
        public static void GravaLogSistema(int tabelaSistemaId, int registroId, int acaoId, string descricao, int? funcaoId)
        {
            IHelperRepository _helperRepository = new HelperRepository();
            _helperRepository.IncluiLogSistema(RepositoryBase.Connection, tabelaSistemaId, registroId, acaoId, descricao, funcaoId, RepositoryBase._usuarioId);
        }

    }
}