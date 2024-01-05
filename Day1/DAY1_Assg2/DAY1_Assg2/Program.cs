// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Student marks:");
Console.WriteLine("Enter marks of JAVA");
int java = int.Parse(Console.ReadLine());
Console.WriteLine("Enter marks of C#");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Enter marks of DATA BASE");
int DB = int.Parse(Console.ReadLine());
Console.WriteLine("Enter marks of JAVA SCRIPT");
int JS = int.Parse(Console.ReadLine());
Console.WriteLine("Enter marks of DATA STRUCTURE");
int DS = int.Parse(Console.ReadLine());


int total = java+c+DS+JS+DB;
Console.WriteLine("Total marks obtained:"+total);

float avg = (total / 500)*100;
Console.WriteLine("Average: " + avg);
            