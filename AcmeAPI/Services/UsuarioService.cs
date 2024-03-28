using AcmeAPI.Context;
using AcmeAPI.IService;
using AcmeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcmeAPI.Services
{
    public class UsuarioService : IUsuarioService
    {
        public async Task<Usuario> guardarUsuario(ContextSqlServer contexto, Usuario usuario)
        {
            await contexto.Usuario.AddAsync(usuario);
            await contexto.SaveChangesAsync();
            return usuario;
        }

        public Task<List<Usuario>> listadoUsuarios(ContextSqlServer context)
        {
            return context.Usuario.ToListAsync();
        }


    }
}
