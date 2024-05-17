using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoColasWRS
{
    public class Ticket
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public DateTime HoraEmision { get; set; }

        public Ticket(int numero, string nombre)
        {
            Numero = numero;
            Nombre = nombre;
            HoraEmision = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Ticket #{Numero} - Nombre: {Nombre} - Emitido a las {HoraEmision}";
        }
    }
}
