using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Serie
    {
        public int serie(int inicio, int limite) {
            if (inicio < limite)
            {
                System.Console.WriteLine(inicio);
                return serie(inicio + 1, limite);
            }
        }
    }
}
