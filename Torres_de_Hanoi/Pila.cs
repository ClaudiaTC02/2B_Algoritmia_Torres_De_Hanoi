using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size {             
            get { return Elementos.Count; }
                set { } }

        public int Top {
            get { return Elementos.Count - 1; }
                set { } }

        public List<Disco> Elementos { get; set; }

        /* TODO: Implementar métodos */
        public Pila()
        {
            Elementos = new List<Disco>();
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
        }

        public Disco pop()
        {
            //elementos.count -1 es porque el elemento en elementos.count no existe
            Disco disco = Elementos[Elementos.Count - 1];
            Elementos.RemoveAt(Elementos.Count - 1);
            return disco;
        }                

        public bool isEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            return false;
        }

    }
}
