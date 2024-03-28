using AcmeAPI.Context;
using AcmeAPI.IService;
using AcmeAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AcmeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet]
        public Task<List<Usuario>> Get([FromServices] ContextSqlServer context, [FromServices] IUsuarioService usuarioService )
        {
            return usuarioService.listadoUsuarios(context);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public string Post([FromBody] Usuario usuario, [FromServices] ContextSqlServer context, [FromServices] IUsuarioService usuarioService)
        {
            try
            {
                
                usuarioService.guardarUsuario(context, usuario);
                string mensaje = "Se guardo Correctamente";
                return mensaje;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "Ocurrio un error";

            }
            
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
