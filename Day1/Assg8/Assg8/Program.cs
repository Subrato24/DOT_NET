// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a year to check it is leap year or not");
int year = int.Parse(Console.ReadLine());
if ((year % 100 != 0&& year % 4 == 0 )|| (year % 400 == 0))
{
    Console.WriteLine("it's a leap year");
}
else
{
    Console.WriteLine("it's not leap year");
}