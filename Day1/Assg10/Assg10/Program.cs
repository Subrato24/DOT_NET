// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number one");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number one");
int num2 = int.Parse(Console.ReadLine());


Console.WriteLine("Select one");
Console.WriteLine("1)Add");
Console.WriteLine("2)Sub");
Console.WriteLine("3)Mul");
Console.WriteLine("4)Div");
int val = int.Parse(Console.ReadLine());

switch (val)
{
    case 1: Console.WriteLine(num1 + num2);
            break;
    case 2:
        Console.WriteLine(num1 - num2);
        break;
    case 3:
        Console.WriteLine(num1 * num2);
        break;
    case 4:
        Console.WriteLine(num1 / num2);
        break;
    default:
        Console.WriteLine("invalid choise");
        break;
}