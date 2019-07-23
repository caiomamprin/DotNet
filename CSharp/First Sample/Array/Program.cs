using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Dimensional
            int[] a1 = new int[3];
            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;
            //a1[5] = 50; Error

            bool[] a2 = new bool[] { true, false, true };

            string[] a3 = { "one", "two", "three" };

            //a3.Length

            //MultiDimensional Array
            int[,] ma1 = new int[3, 3];
            ma1[0, 0] = 1;


            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("OK");
            al.Add(true);

            string als = (string)al[1];

            //Generics C# List<T>
            List<int> l1 = new List<int>();
            l1.Add(10);
            l1.Add(20);
            l1.Add(30);

            List<bool> l2 = new List<bool>();
            

            


        }
    }
}
