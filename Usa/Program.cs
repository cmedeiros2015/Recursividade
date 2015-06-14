using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonacci;

namespace Usa
{
    class Program
    {
        public static void Main(string[] args)
        {
            int res,ini = 10,lim = 30,saida;
            System.Console.WriteLine("Digite um valor: ");
            int num = int.Parse(System.Console.ReadLine());
            Fib fb = new Fib();
            res = fb.cFib(num);
            System.Console.WriteLine(res);
            Serie s = new Serie();
            saida = s.serie(ini, lim);
            System.Console.WriteLine(saida);
            System.Console.ReadKey();
        }
    }
}
