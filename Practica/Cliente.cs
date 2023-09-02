using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Cliente : Usuario
    {
        public double LitrosCargados { get; set; }
        public Cliente(string nombre, double saldo, double litrosCargados) : base(nombre, saldo)
        {
            LitrosCargados = litrosCargados;
        }


        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Saldo: ${Saldo}");
            Console.WriteLine($"LitrosCargados: ${LitrosCargados}");
        }

    }
}
