using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a list of numbers and a number k, return whether any two
                numbers from the list add up to k.

                For example, given [10, 15, 3, 7] and k of 17, return true
                since 10 + 7 is 17.

                Bonus: Can you do this in one pass?
             */

            var numbers = new List<int>();

            Console.WriteLine("Enter numbers (to finish - enter 0)");
            var number = 0;

            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number != 0)
                {
                    numbers.Add(number);
                }
            } while (number != 0);

            Console.WriteLine("Enter number to check:");
            var k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Checking {0} against: ", k);

            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();

            var p = new Program();
            var answer = p.Check(numbers, k);
            Console.WriteLine(answer ? "True" : "False");
        }

        public bool Check(List<int> numbers, int k)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] + numbers[j] == k)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
