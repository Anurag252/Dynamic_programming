using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_flood_fill
{
    class Program
    {
        static void Main(string[] args)
        {
//            3
//3 4
//0 1 1 0 1 1 1 1 0 1 2 3
//0 1 5
//2 2
//1 1 1 1
//0 1 8
//4 4
//1 2 3 4 1 2 3 4 1 2 3 4 1 3 2 4
//0 2 9

            int number_of_testcases = Int32.Parse(Console.ReadLine());
            List<object> list = new List<object>();
            for (int i = 0; i < number_of_testcases; i++)
            {
                int row = Int32.Parse(Console.ReadLine().Split(' ')[0]);
                int column = Int32.Parse(Console.ReadLine().Split(' ')[1]);
                int[,] arr = new int[row,column];
                string entries = Console.ReadLine();

                for (int j = 0; j < row; j ++)
                {
                    for (int k = 0; k < column; k++)
                    {
                        arr[j , k ] = entries.spl
                    }
                }

            }

        }
    }
}
