using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_subset
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases =  Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < testCases;  i++)
            {
                List<int> arr = new List<int>();
                Console.ReadLine();
                //new int[Convert.ToInt32(Console.ReadLine())];
                string eachCase = Console.ReadLine();
                arr = eachCase.Split(' ').Select(x => Convert.ToInt32(x)).ToList();
                caclulate(new List<int>() , arr , 0 , arr.Sum(),0 , 0 - arr.Sum());
            }
        }

        private static void caclulate(List<int> arr1 ,List<int> arr2, int sum1 , int sum2 , int rank , int diff)
        {
            if (rank == arr2.Count)
            {
                return;
            }
            else { for (int i = rank; i < arr2.Count; i ++ )
                {


                    sum1 = sum1 + arr2[rank];
                    sum2 = sum2 - arr2[rank];
                    
                    diff = Math.Abs(sum1 - sum2);
                    var arr1cp = arr1;
                    arr1cp.Add(arr2[rank]);
                    var arr2cp = arr2;
                    arr2cp.Remove(arr2[rank]);
                    caclulate(arr1cp,arr2cp, sum1 ,sum2 , rank = rank + 1, diff);
                    Console.WriteLine(sum1 + " " +  sum2 + " " + rank + " " + diff);

                }

                        }
        }
    }
}
