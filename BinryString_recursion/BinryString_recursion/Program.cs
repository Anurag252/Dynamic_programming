using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinryString_recursion
{
    class Program
    {
        static void Main(string[] args)
        {

            calc("", 3);
        }

        private static void calc(string v1, int v2)
        {

            if (v2 == 1)

            {
                Console.WriteLine(v1 + "0");
                Console.WriteLine(v1 + "1");
            }
            else
            {
                calc(v1 + "0", v2 - 1);
                calc(v1 + "1", v2 - 1);
            }

        }
    }
}
