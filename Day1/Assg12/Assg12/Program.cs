using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee no. Department n.o and Designation Code");
            int dpt = int.Parse(Console.ReadLine());
            char desg = char.Parse(Console.ReadLine());

            if(dpt == 10 && desg== 'M' ) {
                Console.WriteLine("Department n.o:" + dpt + "| Department Name:Purchase | Designation Code:" + desg + "| Designation: Manager");
            }
            else if (dpt == 20 && desg == 'S')
            {
                Console.WriteLine("Department n.o:" + dpt + "| Department Name:Sales | Designation Code:" + desg + "| Designation: Supervisor");
            }
            else if (dpt == 30 && desg == 'A')
            {
                Console.WriteLine("Department n.o:" + dpt + "| Department Name:Production | Designation Code:" + desg + "| Designation: Analyst");
            }
            else if (dpt == 40 && desg == 's')
            {
                Console.WriteLine("Department n.o:" + dpt + "| Department Name:Marketing | Designation Code:" + desg + "| Designation: Sales Person");
            }
            else if (dpt == 50 && desg == 'a')
            {
                Console.WriteLine("Department n.o:" + dpt + "| Department Name:Accounts | Designation Code:" + desg + "| Designation:Accountant");
            }
            else
            {
                Console.WriteLine("Invalid Inputs");
            }
        }
    }
}
