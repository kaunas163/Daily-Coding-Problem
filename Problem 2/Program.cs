using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given an array of integers, return a new array such that each element at
                index i of the new array is the product of all the numbers in the original
                array except the one at i.

                For example, if our input was [1, 2, 3, 4, 5], the expected output
                would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected
                output would be [2, 3, 6].

                Follow-up: what if you can't use division?
             */

            var p = new Program();

            var numbers = new List<int>();
            var number = 0;

            Console.WriteLine("Enter numbers (to finish - input 0)");

            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number != 0)
                {
                    numbers.Add(number);
                }
            } while (number != 0);

            p.PrintList("Entered numbers", numbers);

            var newNumbers = p.Calculate(numbers);
            p.PrintList("Calculated numbers", newNumbers);
        }

        public void PrintList(string comment, List<int> list)
        {
            Console.Write(comment + ": ");

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public List<int> Calculate(List<int> originalData)
        {
            var newData = new List<int>();

            for (int i = 0; i < originalData.Count; i++)
            {
                var calculatedNumber = 1;

                for (int j = 0; j < originalData.Count; j++)
                {
                    if (i != j)
                    {
                        calculatedNumber *= originalData[j];
                    }
                }

                newData.Add(calculatedNumber);
            }

            return newData;
        }
    }
}
