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
            Console.WriteLine("El numero de discos es: "+ n);
            for (int i = n; i>0;i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                ini.push(disco);
            }
            Hanoi hanoi = new Hanoi();
            //ITERATIVO
            Console.WriteLine("A través del modo iterativo");
            double resultado_iterativo = hanoi.iterativo(n, ini, fin, aux);
            Console.WriteLine("El numero de movimientos fue de: "+ resultado_iterativo);
            //calculo los movimientos mínimos
            double movimientos_min = Math.Pow(2, n)-1;
            if (resultado_iterativo == movimientos_min)
            {
                Console.WriteLine("Corresponde con el número mínimo de movimientos");
            }
            else
            {
                Console.WriteLine("No corresponde con el número mínimo de movimietnos");
            }
            //RECURISVO
            Pila ini_r = new Pila();
            Pila aux_r = new Pila();
            Pila fin_r = new Pila();
            Hanoi hanoi_r = new Hanoi();
            for (int i = n; i>0;i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                ini_r.push(disco);
            }
            Console.WriteLine("A través del modo recursivo");
            double resultado_recursivo = hanoi_r.recursivo(n, ini_r, fin_r, aux_r, true);
            Console.WriteLine("El numero de movimientos fue de: "+ resultado_recursivo);
            //calculo los movimientos mínimos
            if (resultado_recursivo == movimientos_min)
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
