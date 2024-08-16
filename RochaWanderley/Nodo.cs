using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RochaWanderley
{
    public class Nodo
    {
        public int Data { get; set; }
        public Nodo  Next { get; set; }

        public Nodo (int data)
        {
            Data = data;
            Next = null;
        }
    }
}
