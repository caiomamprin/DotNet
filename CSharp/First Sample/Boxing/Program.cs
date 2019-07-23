using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object o = (object)a;
            //System.Object 

            Console.WriteLine(o.GetType().ToString());

            int b = (int)o;

            System.Type t = b.GetType();

            // ( (int)o )

            Console.WriteLine(b);

            

            Console.ReadKey();
        }
    }
}
