using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        private static int max = 0;
        static void Main(string[] args)
        {
            string s = "euazbipzncptldueeuechubrcourfpftcebikrxhybkymimgvldiwqvkszfycvqyvtiwfckexmowcxztkfyzqovbtmzpxojfofbvwnncajvrvdbvjhcrameamcfmcoxryjukhpljwszknhiypvyskmsujkuggpztltpgoczafmfelahqwjbhxtjmebnymdyxoeodqmvkxittxjnlltmoobsgzdfhismogqfpfhvqnxeuosjqqalvwhsidgiavcatjjgeztrjuoixxxoznklcxolgpuktirmduxdywwlbikaqkqajzbsjvdgjcnbtfksqhquiwnwflkldgdrqrnwmshdpykicozfowmumzeuznolmgjlltypyufpzjpuvucmesnnrwppheizkapovoloneaxpfinaontwtdqsdvzmqlgkdxlbeguackbdkftzbnynmcejtwudocemcfnuzbttcoew";

        calc(s, 0);



        }

        public static void calc(string s, int count)
        {
            if (s.Length == 0)
            {
                if (max < count)
                {
                    max = count;
                }
                return;
            }
            else
            {
                if (s.Length == 1)
                {
                    count = count + 1;
                    if (max < count)
                    {
                        max = count;
                    }
                }
                else
                {
                    if (max < count)
                    {
                        max = count;
                    }

                    int flag = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        for (int j = s.Length - 1; j > i; j--)
                        {
                            if (s[i] == s[j])
                            {
                                flag = 1;
                                calc(s.Substring(i + 1, j - i - 1 ), count + 2);
                                

                            }
                        }
                    }
                    if (flag == 0)
                    {
                        count = count + 1;
                        if (max < count)
                        {
                            max = count;
                        }
                    }
                }
            }
        }
    
}
}
