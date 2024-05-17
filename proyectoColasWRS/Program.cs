using System.Net.Sockets;

namespace proyectoColasWRS
{
    
    public class Program
    {
        private static Queue<Ticket> colaTickets = new Queue<Ticket>();
        private static int ultimoNumero = 0;

        public static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Emitir ticket");
                Console.WriteLine("2. Mostrar lista de personas con tickets");
                Console.WriteLine("3. Atender siguiente ticket");
                Console.WriteLine("4. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        EmitirTicket();
                        break;
                    case "2":
                        MostrarListaDeTickets();
                        break;
                    case "3":
                        AtenderTicket();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                        break;
                }
            }
        }

        private static void EmitirTicket()
        {
            ultimoNumero++;
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Ticket nuevoTicket = new Ticket(ultimoNumero, nombre);
            colaTickets.Enqueue(nuevoTicket);
            Console.WriteLine($"Se ha emitido {nuevoTicket}");
        }

        private static void MostrarListaDeTickets()
        {
            if (colaTickets.Count > 0)
            {
                Console.WriteLine("Personas con tickets en la cola:");
                foreach (var ticket in colaTickets)
                {
                    Console.WriteLine(ticket);
                }
            }
            else
            {
                Console.WriteLine("No hay tickets en la cola.");
            }
        }

        private static void AtenderTicket()
        {
            if (colaTickets.Count > 0)
            {
                Ticket ticketAtendido = colaTickets.Dequeue();
                Console.WriteLine($"Atendiendo {ticketAtendido}");
            }
            else
            {
                Console.WriteLine("No hay tickets en la cola para atender.");
            }
        }
    }

}