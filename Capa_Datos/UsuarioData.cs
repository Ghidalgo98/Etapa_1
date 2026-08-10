using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Capa_Modelos;


namespace Capa_Datos
{
   public class UsuarioData
    {
        private readonly BaseContext _context;
        public UsuarioData (BaseContext context)
        {
            _context = context;
        }

        public Usuario? ObtenerUsuarioPorNombre(string username)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Usuario_Logueo == username);
        }

    }
}
