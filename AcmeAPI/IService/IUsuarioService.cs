using AcmeAPI.Context;
using AcmeAPI.Models;

namespace AcmeAPI.IService
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> listadoUsuarios( ContextSqlServer contexto);
        Task<Usuario> guardarUsuario(ContextSqlServer contexto, Usuario usuario);
    }
}
