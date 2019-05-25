using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generate_n_lengthstring_from_k_lengh_set
{
    class Program
    {
        static void Main(string[] args)
        {
            calc("", 3, "ABCD");
        }

        private static void calc(string v1, int v2, string v3)
        {
            if(v2 == 1)
            {
                for (int i = 0; i < v3.Length; i++)
                {
                    Console.WriteLine(v1 + v3[i]);
                }
               
            }
            else
            {
                for (int i = 0; i < v3.Length; i++)
                {
                    calc(v1 + v3[i], v2 - 1, v3);
                }
            }
        }
    }
}
