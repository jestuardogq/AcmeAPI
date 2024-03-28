using AcmeAPI.Context;
using AcmeAPI.Models;

namespace AcmeAPI.IService
{
    public interface IEncuestaService
    {
        Task<List<Encuesta>> GetEncuestaListAsync(ContextSqlServer contexto);
        Task<string> guardarEncuesta(ContextSqlServer contexto, Encuesta encuesta);
    }
}
