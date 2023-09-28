using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana6__problema01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacidadMaxima = 0;
            int personasActuales = 0;

            Console.WriteLine("Bienvenido al sistema de control de aforo de la tiendita de Don Mariano");
            Console.Write("Por favor, ingrese el número máximo de personas permitidas en el local: ");

            while (capacidadMaxima <= 0 || capacidadMaxima > 50)
            {
                if (int.TryParse(Console.ReadLine(), out capacidadMaxima) && capacidadMaxima > 0 && capacidadMaxima <= 50)
                {
                    Console.WriteLine($"El número máximo establecido es de {capacidadMaxima} personas.");
                    Console.WriteLine("Presione cualquier tecla para comenzar a contar.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido entre 1 y 50.");
                    Console.Write("Por favor, ingrese el número máximo de personas permitidas en el local: ");
                }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Aforo actual: {personasActuales} / {capacidadMaxima}");
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Persona entra al local");
                Console.WriteLine("2. Persona sale del local");
                Console.WriteLine("3. Salir del programa");

                int opcion;

                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
                {
                    Console.WriteLine("Por favor, seleccione una opción válida.");
                }

                switch (opcion)
                {
                    case 1:
                        if (personasActuales < capacidadMaxima)
                        {
                            personasActuales++;
                            Console.WriteLine("Una persona ha entrado al local.");
                        }
                        else
                        {
                            Console.WriteLine("El local está lleno. No se permite la entrada.");
                        }
                        break;
                    case 2:
                        if (personasActuales > 0)
                        {
                            personasActuales--;
                            Console.WriteLine("Una persona ha salido del local.");
                        }
                        else
                        {
                            Console.WriteLine("No hay personas en el local para que salgan.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa. ¡Gracias por usar el sistema de control de aforo!");
                        return;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

}
    

