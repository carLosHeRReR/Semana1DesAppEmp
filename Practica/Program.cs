using Practica;

class Program
{
    static void Main(string[] args)
    {
        List<Usuario> usuarios = new List<Usuario>();
        Grifo grifo = new Grifo();

        while (true)
        {
            Console.WriteLine("Selecciona una acción:");
            Console.WriteLine("1. Mostrar información de usuarios");
            Console.WriteLine("2. Agregar Cliente");
            Console.WriteLine("3. Agregar Empleado");
            Console.WriteLine("4. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    grifo.MostrarUsuarios();
                    Mostrarinfo(usuarios);
                    break;

                case 2:
                    Console.WriteLine("Ingresa el nombre del cliente:");
                    string nombreCliente = Console.ReadLine();
                    Console.WriteLine("Ingresa el saldo del cliente:");
                    double saldoCliente = Convert.ToDouble(Console.ReadLine());
                    double litrosCargados = double.Parse(Console.ReadLine());
                    Cliente cliente = new Cliente(nombreCliente, saldoCliente, litrosCargados);
                    usuarios.Add(cliente);
                    break;

                case 3:
                    Console.WriteLine("Ingresa el nombre del empleado:");
                    string nombreEmpleado = Console.ReadLine();
                    Console.WriteLine("Ingresa el saldo del empleado:");
                    double saldoEmpleado = Convert.ToDouble(Console.ReadLine());
                    grifo.AgregarUsuario(new Empleado(nombreEmpleado, saldoEmpleado));
                    break;

                case 4:
                    Console.WriteLine("¡Hasta pronto!");
                    return;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void Mostrarinfo(List<Usuario> usuarios)
        {
            foreach (var usuarario in usuarios)
            {
                usuarario.MostrarInformacion(); Console.WriteLine();
            }
        }
    }
}