using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();
            int n = 3;
            Console.WriteLine("El numero de discos es"+ n);
            for (int i = n; i>0;i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                ini.push(disco);
            }
            Hanoi hanoi = new Hanoi();
            Console.WriteLine("A través del modo iterativo");
            double resultado = hanoi.iterativo(n, ini, fin, aux);
            Console.WriteLine("El numero de movimientos fue de: "+ resultado);
            //calculo los movimientos mínimos
            double movimientos_min = Math.Pow(2, n)-1;
            if (resultado == movimientos_min)
            {
                Console.WriteLine("Corresponde con el número mínimo de movimientos");
            }
            else
            {
                Console.WriteLine("No corresponde con el número mínimo de movimietnos");
            }
            Console.WriteLine("Press any key to exit.");
           
            Console.ReadKey();
        }
    }
}
