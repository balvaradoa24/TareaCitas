using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tareas
{
    internal class Program
    {

        static void Main(string[] args)

        {
            int tamanno = 2;
            String[] nombre = new string[tamanno];
            int[] edad = new int[tamanno];
            string[] cita = new string[tamanno];
            int opcion = 0;

            menu();

            void inicializar()
            {
                nombre = Enumerable.Repeat("", tamanno).ToArray<string>();
                cita = Enumerable.Repeat("", tamanno).ToArray<string>();
                edad = Enumerable.Repeat(0, tamanno).ToArray<int>();
                Console.WriteLine("Los arreglos han sido inicializados...");
                Console.ReadKey();
                Console.Clear();
            }

            void agregar()
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < nombre.Length; i++)
                {
                    Console.WriteLine("Ingrese el nombre: "); nombre[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad: "); edad[i] = int.Parse(Console.ReadLine());

                }


            }

            void consulta()
            {
                bool encontrado = false;
                Console.WriteLine("Digite el nombre a buscar: ");
                string nomb = Console.ReadLine();

                for (int i = 0; i < nombre.Length; i++)
                {
                    if (nomb.Equals(nombre[i]))
                    {
                        Console.WriteLine($"La edad de {nomb} es {edad[i]}");
                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine($"El cliente {nomb} no existe");
                }
            }

            void asignarCita()

            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < cita.Length; i++)
                {
                    Console.WriteLine("Digite la fecha en la que desea asignar la cita en el siguiente formato Dia/Mes/Año = 01/11/2024"); cita[i] = Console.ReadLine();

                }
            }
            void reporte()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Nombre          Edad            Cita");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("------          -------     -------");
                for (int i = 0; i < nombre.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{nombre[i]}            {edad[i]}         {cita[i]}");

                }
            }
            void menu()
            {

                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("********************** CONSULTORIO MEDICO *************************");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("0-Inicializar Arreglos");
                    Console.WriteLine("1-Ingresar paciente");
                    Console.WriteLine("2-Consultar paciente");
                    Console.WriteLine("3-Asignar citas");
                    Console.WriteLine("4-Reporte");
                    Console.WriteLine("5-Salir");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("..Digite una opcion..");
                    opcion = int.Parse(Console.ReadLine());


                    switch (opcion)
                    {
                        case 0: inicializar(); break;
                        case 1: agregar(); break;
                        case 2: consulta();  break;
                        case 3: asignarCita();  break;
                        case 4: reporte(); break;

                        default:
                            Console.WriteLine("Elegiste salir del programa, gracias por utilizarlo");
                            break;
                    }
                } while (true);
            }


        }

    }
}


