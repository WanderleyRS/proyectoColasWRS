using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RochaWanderley
{
    public class LinkedList
    {
        private Nodo head;

        public LinkedList()
        {
            head = null;
        }

        // Agregar nodo al inicio
        public void AddFirst(int data)
        {
            Nodo newNode = new Nodo(data);
            newNode.Next = head;
            head = newNode;
        }

        // Agregar nodo al final
        public void AddLast(int data)
        {
            Nodo newNode = new Nodo(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Nodo current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Imprimir todos los elementos
        public void PrintList()
        {
            Nodo current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        public void Remove(int data)
        {
            if (head == null) return;

            // Si el nodo a eliminar es el primero
            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Nodo current = head;
            Nodo previous = null;

            while (current != null && current.Data != data)
            {
                previous = current;
                current = current.Next;
            }

            // Si el valor no se encuentra en la lista
            if (current == null) return;

            // Eliminar el nodo
            previous.Next = current.Next;
        }

        public Nodo FindMiddle()
        {
            if (head == null) return null;

            Nodo slow = head;
            Nodo fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }

        public void Reverse()
        {
            Nodo prev = null;
            Nodo current = head;
            Nodo next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            head = prev;
        }





    }
}
