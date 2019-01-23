using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;

            while (i <= 5)
            {
                sum += i;
                i++;
            }
                Console.WriteLine("sum is {0}", sum);
            
        }
    }
}
