using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal_or_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool repeat = true;
            bool invalid = true;

            while (repeat)
            {
                Console.WriteLine(@"
Type 1 for make a binary to decimal
Type 2 for make a decimal to binary");
                while (invalid)
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            invalid = false;
                            Console.WriteLine("Plz enter a binary string which is less than 20 characters");
                            Console.WriteLine(solution.BinaryToDecimal(Console.ReadLine()));
                            break;

                        case "2":
                            invalid = false;
                            Console.WriteLine("Plz enter a decimal string which is less than 1048575");
                            Console.WriteLine(solution.DecimalToBinary(Console.ReadLine()));
                            break;

                        default:
                            invalid = true;
                            Console.WriteLine("Just 1 or 2. Thx");
                            break;
                    }
                }
                Console.WriteLine(@"
                Type Q to quit");
                switch (Console.ReadLine().ToUpper())
                {
                    case "Q":
                        repeat = false;
                        break;

                    default:
                        repeat = true;
                        invalid = true;
                        Console.WriteLine("convert again");
                        break;
                }

            }
        }

        public class Solution
        {
            public string BinaryToDecimal(string a)
            {
                ulong aBinary = ulong.Parse(a);
                ulong aInt = 0;
                ulong countA = 0;
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
                return aInt.ToString();
            }

            public string DecimalToBinary(string b)
            {
                ulong bInt = ulong.Parse(b);
                ulong bBinary = 0;
                ulong countB = 0;

                while (bInt > 0)
                {
                    ulong times = 1;
                    for (ulong i = 0; i < countB; i++)
                    {
                        times = 10 * times;
                    }
                    bBinary = bBinary + bInt % 2 * times;
                    bInt /= 2;
                    countB++;
                }

                return bBinary.ToString();
            }
        }
    }
}
