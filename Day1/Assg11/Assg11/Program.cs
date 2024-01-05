using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three number to compare max");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if ((num1 > num2)&&(num1>num3))
            {
                Console.WriteLine(num1 + " is greater among");
            }
            else if((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine(num2 + " is greater among");
            }
            else if((num3 > num2) && (num3 > num1))
            {
                Console.WriteLine(num3 + " is greater among");
            }
        }
    }
}
