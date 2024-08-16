using System.Xml.Linq;

namespace RochaWanderley
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            int opcionMenu = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("/ ------ OPCIONES DE LISTA --------------/");
                Console.WriteLine("/ ---------------------------------------/");
                Console.WriteLine("/ 1.- INSERTAR AL FINAL -----------------/");
                Console.WriteLine("/ 2.- ELIMINAR --------------------------/");
                Console.WriteLine("/ 3.- MOSTRAR NODO MEDIO ----------------/");
                Console.WriteLine("/ 4.- INVERTIR LISTA --------------------/");
                Console.WriteLine("/ 5.- DESPLEGAR LISTA -------------------/");
                Console.WriteLine("/ 6.- SALIR -----------------------------/");
                Console.WriteLine("/ ---------------------------------------/");
                Console.WriteLine("ESCOJA UNA OPCIÓN:");
                opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ingrese el valor a insertar al final: ");
                        int dataFinal = int.Parse(Console.ReadLine());
                        list.AddLast(dataFinal);
                        Console.WriteLine("Nodo insertado al final.");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Ingrese el valor a eliminar: ");
                        int dataEliminar = int.Parse(Console.ReadLine());
                        list.Remove(dataEliminar);
                        Console.WriteLine("Nodo eliminado.");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Nodo middle = list.FindMiddle();
                        Console.WriteLine("Nodo medio: " + (middle != null ? middle.Data.ToString() : "null"));
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        list.Reverse();
                        Console.WriteLine("Lista invertida.");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Lista actual:");
                        list.PrintList();
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        break;
                }

            } while (opcionMenu != 6);
        }
    }
}