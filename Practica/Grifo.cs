using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Grifo
    {
        private List<Usuario> usuarios { get; set; }


        public void MostrarUsuarios () 
        {
            foreach (var usuario in usuarios)
            {
                usuario.MostrarInformacion();
            }
        }

        internal void AgregarUsuario(Usuario usuario)
        {
            usuario.add(usuario);
        }
    }
}
