using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        private int movimientos = 0;
        private int discos;
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (b.isEmpty())
            {
                mover(a,b);
            } else if (a.isEmpty())
            {
                mover(b, a);
            }
            else
            {
                //si el disco de a tiene un valor mas grande al de b
                if(b.Elementos[b.Top].Valor < a.Elementos[a.Top].Valor)
                {
                    //mover el disco de b y ponerlo en a
                    mover(b,a);
                }
                else
                {
                    //mover el disco de a y ponerlo en b
                    mover(a, b);
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            discos = n;
            bool solucion = false;
            if(n%2 != 0)
            {
                while(solucion == false)
                {
                    incrementar_movimientos(ini, fin, fin);
                    incrementar_movimientos(ini, aux, fin);
                    incrementar_movimientos(aux, fin, fin);
                    if (fin.Size == n)
                    {
                        solucion = true;
                    }
                }
            }
            else
            {
                while(solucion == false)
                {
                    incrementar_movimientos(ini, aux, fin);
                    incrementar_movimientos(ini, fin, fin);
                    incrementar_movimientos(aux, fin, fin);
                    if (fin.Size == n)
                    {
                        solucion = true;
                    }
                }
            }
            return movimientos;
        }
        public void mover(Pila sacar, Pila poner)
        {
            //quito el disco en top y lo guardo en disco
            Disco disco = sacar.pop();
            //mensaje del movimiento que realizo
            Console.WriteLine("Se movió el disco: " + disco.Valor);
            //pongo el disco en la otra pila
            poner.push(disco);
        }
        public void incrementar_movimientos(Pila a, Pila b, Pila fin)
        {
            if (fin.Size != discos)
            {
                mover_disco(a, b);
                movimientos++;
            }
        }

    }
}
