using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            do
            {
                Console.WriteLine("Esta es la vez numero " + contador + " que pasa por aqui");
                contador++;
            } while (contador < 10);
            Console.ReadKey();

        }
    }
}