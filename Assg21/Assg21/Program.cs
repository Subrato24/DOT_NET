using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select one");
            Console.WriteLine("a) Square");
            Console.WriteLine("b) Circle");
            Console.WriteLine("c) Rectangle");

            char val = char.Parse(Console.ReadLine());

            switch(val)
            {
                case 'a':

                    break;
                case 'b':
                    Console.WriteLine("Enter the readius");
                    int r = int.Parse(Console.ReadLine());

                    Console.WriteLine("what you want to find");
                    Console.WriteLine("1) Calculate Area");
                    Console.WriteLine("2) Calculate perimeter");
                    Console.WriteLine("3) Calculate area and perimeter both");

                    int find = int.Parse(Console.ReadLine());

                    switch (find)
                    {
                        case 1:
                           
                            double area = 3.14 * r * r;
                            Console.WriteLine("Area of Circle is:" + area);
                            break;
                        case 2:
                            double peri = 2 * 3.14 * r;
                            Console.WriteLine("Perimeter of Circle is:" + peri);
                            break;
                        case 3:
                            Console.WriteLine("Area of Circle is:" +(3.14 * r * r)+ " Perimeter of Circle is:"+ (2 * 3.14 * r));
                            break;
                        default:
                            Console.WriteLine("Invalid!!!");
                            break;
                    }
                    break;
                case 'c':
                    Console.WriteLine();
                    break;
            }
        }
    }
}
