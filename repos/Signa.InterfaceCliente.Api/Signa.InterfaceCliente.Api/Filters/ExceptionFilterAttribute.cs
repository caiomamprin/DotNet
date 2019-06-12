using Signa.InterfaceCliente.Api.Data.Repository;
using Signa.Library.Helpers;
using Signa.Library.Interface;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace Signa.InterfaceCliente.Api.Filters
{
    public class ExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        bool IFilter.AllowMultiple => true;


        public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {

            IExceptionFilterSigna _exp = new ExceptionFilter();
            object retorno = _exp.ExecuteExceptionFilter(RepositoryBase.Connection, actionExecutedContext, cancellationToken);
            actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new ObjectContent(new object().GetType(), retorno, new JsonMediaTypeFormatter())
            };
            return Task.FromResult(0);
        }
    }
}