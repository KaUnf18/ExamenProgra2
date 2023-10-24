using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseEmpleado
{
    public class Empleado
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public double Salario { get; set; }

        public Empleado(string cedula, string nombre, string direccion, string telefono, double salario)
        {
            Cedula = cedula;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Salario = salario;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la información del empleado:");
            Console.Write("Cedula: ");
            string cedula = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();
            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();
            Console.Write("Salario: ");
            double salario;
            double.TryParse(Console.ReadLine(), out salario);

            Empleado empleado = new Empleado(cedula, nombre, direccion, telefono, salario);

            Console.WriteLine("Información del empleado:");
            Console.WriteLine($"Cedula: {empleado.Cedula}");
            Console.WriteLine($"Nombre: {empleado.Nombre}");
            Console.WriteLine($"Dirección: {empleado.Direccion}");
            Console.WriteLine($"Teléfono: {empleado.Telefono}");
            Console.WriteLine($"Salario: {empleado.Salario}");
        }
    }
}

