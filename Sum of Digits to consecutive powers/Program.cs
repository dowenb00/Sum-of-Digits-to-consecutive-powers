using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Find the sum of a string's digits to consecutive powers. e.g., 735 => 7^1 + 3^2 + 5^3.
namespace Sum_of_Digits_to_consecutive_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 1;
            long b = 135;
            int result = 0;
            List<long> nums = new List<long> { };

            

            for (long i = a; i <= b; i++)
            {
                char[] digits = (i).ToString().ToCharArray();
                
                for (int x = 0; x < digits.Length; x++)
                {
                    result += (int)Math.Pow(Char.GetNumericValue(digits[x]), x + 1);
                }

                if (result == i)
                {
                    nums.Add(i);
                }
                

                result = 0;
            }

            foreach (long n in nums)
            {
                Console.WriteLine(n);
            }
            long[] final = nums.ToArray();
        }
    }
}
