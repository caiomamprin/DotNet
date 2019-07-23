using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            /*do
            {
                //a = a + 1;
                a++;
                Console.WriteLine(a.ToString());
            } while (a < 10);*/

            int b = 10;

            while (b >= 1)
            {
                Console.WriteLine(b.ToString());
                b--; //b--;
            }

            Console.ReadKey();
        }

    }
}
