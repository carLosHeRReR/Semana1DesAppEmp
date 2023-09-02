using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public double Saldo { get; set; }

        // Constructor
        public Usuario(string nombre, double saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }

        // Método virtual 
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Saldo: ${Saldo}");
        }

        internal void add(Usuario usuario)
        {
            usuario.add(usuario);
        }
    }
}
