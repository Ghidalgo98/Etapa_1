using Capa_Datos;
using Capa_Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Usuario_Login
    {
        private readonly UsuarioData _usuarioData;

        public Usuario_Login(UsuarioData usuarioData)
        {
            _usuarioData = usuarioData;
        }
        private byte[] GenerarHash(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                return sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public Usuario? Login(string username, string password)
        {
            var usuario = _usuarioData.ObtenerUsuarioPorNombre(username);

            if (usuario != null)
            {
                var hashIngresado = GenerarHash(password);

                if (usuario.Contraseña.SequenceEqual(hashIngresado))
                {
                    return usuario; // Login correcto
                }
            }

            return null; // Login incorrecto
        }
    }
}
