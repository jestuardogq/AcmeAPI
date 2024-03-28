using AcmeAPI.Context;
using AcmeAPI.IService;
using AcmeAPI.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace AcmeAPI.Services
{
    public class EncuestaService : IEncuestaService
    {
        public Task<List<Encuesta>> GetEncuestaListAsync(ContextSqlServer contexto)
        {
            return contexto.Encuesta.ToListAsync();
        }

        public async Task<string> guardarEncuesta(ContextSqlServer contexto, Encuesta encuesta)
        {
            contexto.Encuesta.Add(encuesta);
            await contexto.SaveChangesAsync();
            return "Se guardo correctamente";
            
        }
    }
}
