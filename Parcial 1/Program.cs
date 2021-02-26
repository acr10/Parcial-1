using System;

namespace Parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
        

                Lista milista = new Lista();
                string op;
                do
                {
                    Console.Clear();
                    Console.WriteLine("|---------------------------------------------------------------------- -| ");
                    Console.WriteLine("| Elija una opcion                                                       |");
                    Console.WriteLine("|---------------------------------------------------------------------- -| ");
                    Console.WriteLine("|---------------------------------------------------------------------- -| ");
                    Console.WriteLine("| A | Insertar                                                           |");
                    Console.WriteLine("| B | Eliminar por posicion                                              |");
                    Console.WriteLine("| C | Mostrar ascendente                                                 |");
                    Console.WriteLine("| D | Mostrar descendente                                                |");
                    Console.WriteLine("| E | Sumatoria de valores de la lista                                   | ");
                    Console.WriteLine("| F | Salir                                                              |");
                    Console.WriteLine("|----------------------------------------------------------------------- | ");
                    Console.WriteLine("\n");
                    op = Console.ReadLine();
                 switch (op)
                    {
                        case "a":
                        case "A":
                            try
                            {
                                milista.Insertar();
                                Console.ReadKey();
                            }
                            catch
                            {
                                Console.WriteLine("solo se permiten numeros");
                                Console.ReadKey();
                            }

                            break;
                        case "b":
                        case "B":
                            try
                            {
                                Console.Write("Digite la posicion a eliminar");
                                int i = int.Parse(Console.ReadLine());
                                milista.BorrarPorPosicion(i);
                                Console.ReadKey();
                            }
                            catch
                            {
                                Console.WriteLine("solo se permiten numeros");
                                Console.ReadKey();
                            }

                            break;
                        case "c":
                        case "C":

                            milista.Mostrar();
                            Console.ReadKey();



                            break;
                        case "d":
                        case "D":
                            milista.MostrarDescendente();
                            milista.Mostrar();
                            Console.ReadKey();
                            break;
                        case "e":
                        case "E":
                            milista.Sumatoria();
                            Console.ReadKey();
                            break;

                        case "f":
                        case "F":
                            break;

                 }
              
               
                    

                } while (op != "h" && op != "H");
                Console.WriteLine("Usted esta saliendo del programa");
                Console.ReadKey();
        }
         
        
    }
}
