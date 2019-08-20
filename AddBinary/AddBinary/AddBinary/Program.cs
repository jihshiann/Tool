using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBinary
{
    class Program
    {
        public static ulong sumInt = 0;
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Plz enter the first binary digit(limited in 20 bits)");
                string inputA = Console.ReadLine();
                Console.WriteLine("Plz enter the second binary digit(limited in 20 bits)");
                string inputB = Console.ReadLine();
                Console.WriteLine(string.Format("The sum in binary type is {0}, and decimal is {1} ", solution.AddBinary(inputA, inputB), sumInt));
                Console.WriteLine(@"
                Type Q to quit");
                switch (Console.ReadLine().ToUpper())
                {
                    case "Q":
                        repeat = false;
                        break;

                    default:
                        repeat = true;
                        Console.WriteLine("Add again");
                        break;
                }
            }
        }

        public class Solution
        {
            public string AddBinary(string a, string b)
            {
                ulong aBinary = ulong.Parse(a);
                ulong bBinary = ulong.Parse(b);
                ulong aInt = 0;
                ulong bInt = 0;
                ulong countA = 0;
                ulong countB = 0;
                while (aBinary > 0)
                {
                    ulong times = 1;
                    for (ulong i = 0; i < countA; i++)
                    {
                        times = 2 * times;
                    }
                    aInt = aInt + aBinary % 10 * times;
                    aBinary /= 10;
                    countA++;
                }

                while (bBinary > 0)
                {
                    ulong times = 1;
                    for (ulong i = 0; i < countB; i++)
                    {
                        times = 2 * times;
                    }
                    bInt = bInt + bBinary % 10 * times;
                    bBinary /= 10;
                    countB++;
                }
                
                sumInt = aInt + bInt;
                ulong sumBinary = 0;
                ulong countSum = 0;
                ulong sumIntStored = sumInt;
                while (sumIntStored > 0)
                {
                    ulong times = 1;
                    for (ulong i = 0; i < countSum; i++)
                    {
                        times = 10 * times;
                    }
                    sumBinary = sumBinary + sumIntStored % 2 * times;
                    sumIntStored /= 2;
                    countSum++;
                }


                return sumBinary.ToString();
            }
        }
    }
}
