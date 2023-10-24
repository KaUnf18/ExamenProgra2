using System;
using System.Collections.Generic;
using System.Linq;

public class Menu
{
    private List<Empleado> empleados = new List<Empleado>();

    public void MostrarMenuPrincipal()
    {
        int opcion;
        do
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Agregar Empleado");
            Console.WriteLine("2. Consultar Empleados");
            Console.WriteLine("3. Modificar Empleado");
            Console.WriteLine("4. Borrar Empleado");
            Console.WriteLine("5. Inicializar Arreglos");
            Console.WriteLine("6. Reportes");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AgregarEmpleado();
                        break;
                    case 2:
                        ConsultarEmpleados();
                        break;
                    case 3:
                        ModificarEmpleado();
                        break;
                    case 4:
                        BorrarEmpleado();
                        break;
                    case 5:
                        InicializarArreglos();
                        break;
                    case 6:
                        MostrarMenuReportes();
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
            }
        } while (opcion != 7);
    }

    public void MostrarMenuReportes()
    {
        int opcion;
        do
        {
            Console.WriteLine("Menú de Reportes:");
            Console.WriteLine("1. Consultar empleados con número de cédula");
            Console.WriteLine("2. Listar todos los empleados ordenados por nombre");
            Console.WriteLine("3. Calcular y mostrar el promedio de los salarios");
            Console.WriteLine("4. Calcular y mostrar el salario más alto y el más bajo");
            Console.WriteLine("5. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        ConsultarEmpleadosPorCedula();
                        break;
                    case 2:
                        ListarEmpleadosPorNombre();
                        break;
                    case 3:
                        CalcularPromedioSalarios();
                        break;
                    case 4:
                        MostrarSalariosMaximoYMinimo();
                        break;
                    case 5:
                        Console.WriteLine("Volviendo al Menú Principal.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
            }
        } while (opcion != 5);
    }

    public void AgregarEmpleado()
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
        empleados.Add(empleado);
        Console.WriteLine("Empleado agregado con éxito.");
    }

    public void ConsultarEmpleados()
    {
        Console.WriteLine("Lista de empleados:");
        foreach (var empleado in empleados)
        {
            Console.WriteLine($"Cedula: {empleado.Cedula}, Nombre: {empleado.Nombre}, Salario: {empleado.Salario}");
        }
    }

    public void ModificarEmpleado()
    {
        Console.Write("Ingrese la cédula del empleado que desea modificar: ");
        string cedula = Console.ReadLine();

        Empleado empleado = empleados.FirstOrDefault(e => e.Cedula == cedula);

        if (empleado != null)
        {
            Console.WriteLine("Datos del empleado:");
            Console.WriteLine($"Cedula: {empleado.Cedula}");
            Console.WriteLine($"Nombre: {empleado.Nombre}");
            Console.WriteLine($"Dirección: {empleado.Direccion}");
            Console.WriteLine($"Teléfono: {empleado.Telefono}");
            Console.WriteLine($"Salario: {empleado.Salario}");

            Console.WriteLine("Ingrese los nuevos datos del empleado:");
            Console.Write("Nombre: ");
            empleado.Nombre = Console.ReadLine();
            Console.Write("Dirección: ");
            empleado.Direccion = Console.ReadLine();
            Console.Write("Teléfono: ");
            empleado.Telefono = Console.ReadLine();
            Console.Write("Salario: ");
            double salario;
            double.TryParse(Console.ReadLine(), out salario);
            empleado.Salario = salario;

            Console.WriteLine("Empleado modificado con éxito.");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public void BorrarEmpleado()
    {
        Console.Write("Ingrese la cédula del empleado que desea borrar: ");
        string cedula = Console.ReadLine();

        Empleado empleado = empleados.FirstOrDefault(e => e.Cedula == cedula);

        if (empleado != null)
        {
            empleados.Remove(empleado);
            Console.WriteLine("Empleado eliminado con éxito.");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public void InicializarArreglos()
    {
        empleados.Clear();
        Console.WriteLine("Arreglos de empleados inicializados.");
    }

    public void ConsultarEmpleadosPorCedula()
    {
        Console.Write("Ingrese la cédula del empleado a consultar: ");
        string cedulaConsulta = Console.ReadLine();

        Empleado empleado = empleados.FirstOrDefault(e => e.Cedula == cedulaConsulta);

        if

