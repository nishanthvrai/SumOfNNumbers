using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter N");
            var N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
                sum = sum + i;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
