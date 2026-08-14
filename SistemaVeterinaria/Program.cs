using System;
using System.Collections.Generic;

namespace SistemaVeterinaria
{
    class Program
    {
        static List<Mascota> veterinaria = new List<Mascota>();

        static void Main(string[] args)
        {
            bool continuar(string[] args)
            {
                bool continuar = true;

                while (continuar)
                {
                    Console.WriteLine("\n========================================");
                    Console.WriteLine("    VETERINARIA - CONTROL DE CITAS");
                    Console.WriteLine("========================================");
                    Console.WriteLine("1. Registrar nueva mascota");
                    Console.WriteLine("2. Gestionar pacientes (Cambiar estado, dosis, etc.)");
                    Console.WriteLine("3. Salir");
                    Console.Write("Seleccione una opción: ");
                    
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            MenuRegistrarMascota();
                            break;
                        case "2":
                            MenuGestionarPacientes();
                            break;
                        case "3":
                            Console.WriteLine("\nGracias por utilizar el sistema");
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("\nOpción invalida, intente de nuevo.");
                            break;
                    }
                }
            }

            // REGISTAR MASCOTAS
            static void MenuRegistrarMascota()
            {
                Console.WriteLine("\n--- Seleccione la Especie ---");
                Console.WriteLine("1. Perro");
                Console.WriteLine("2. Gato");
                Console.WriteLine("3. Ave");
                Console.WriteLine("4. Tortuga");
                Console.Write("Especie: ");
                string tipo = Console.ReadLine();

                if (tipo != "1" && tipo != "2" && tipo != "3" && tipo != "4")
                {
                    Console.WriteLine("Tipo de mascota inválido");
                    return;
                }
                
                Console.Write("Nombre de la mascota: ");
                string nombre = Console.ReadLine();
                Console.Write("Peso (en kg): ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sexo: ");
                string sexo = Console.ReadLine();
                Console.Write("Edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nombre del Propietario: ");
                string propietario = Console.ReadLine();
            }
        }
    }
}