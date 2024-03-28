using AcmeAPI.Context;
using AcmeAPI.IService;
using AcmeAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AcmeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncuestaController : ControllerBase
    {
        // GET: api/<EncuestaController>
        [HttpGet]
        public Task<List<Encuesta>> Get([FromServices] ContextSqlServer context, [FromServices] IEncuestaService encuestaService)
        {
            
            return encuestaService.GetEncuestaListAsync(context);
        }

        // GET api/<EncuestaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EncuestaController>
        [HttpPost]
        public async Task<Dictionary<String, String>>  Post([FromBody] Encuesta encuesta, [FromServices] ContextSqlServer contexto, [FromServices] IEncuestaService encuestaService)
        {
            Dictionary<String, String> respuesta = new Dictionary<String, String>();
            try
            {
                Task<string> mensaje = encuestaService.guardarEncuesta(contexto, encuesta);
                respuesta.Add("mensaje", "Todo bien");
                return respuesta;
            }
            catch (Exception ex) 
            {
                respuesta.Add("mensaje", "Ocurrio un error en el servidor");
                return respuesta;
            }
        }

        // PUT api/<EncuestaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EncuestaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
