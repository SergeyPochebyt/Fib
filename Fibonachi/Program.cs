using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            var FibList = MyFunction.Fibonachi(20);
            int count = 1;
            foreach (var number in FibList)
            {
                Console.WriteLine($"The {count} element of Fibonachi is {number}");
                count++;
            }

            Console.ReadKey();
        }
    }

    public class MyFunction
    {
        public static List<int> Fibonachi(int n)
        {
            var fibonacciNumber = new List<int>{1,1};

            int count = 0;

            while (count < n - 2)
            {

                var previous = fibonacciNumber[fibonacciNumber.Count - 1];
                var previous2 = fibonacciNumber[fibonacciNumber.Count - 2];
                fibonacciNumber.Add(previous + previous2);
                count++;
            }
            return fibonacciNumber;
        }

    }


}
