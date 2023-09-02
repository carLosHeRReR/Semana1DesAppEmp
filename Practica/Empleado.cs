using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Empleado : Usuario
    {
        public double Sueldo { get; set; }
        public Empleado(string nombre, double saldo, double sueldo) : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }

        public Empleado(string nombre, double saldo) : base(nombre, saldo)
        {
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Saldo: ${Saldo}");
            Console.WriteLine($"Sueldo: ${Sueldo}");
        }
    }
}
