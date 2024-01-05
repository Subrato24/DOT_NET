// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter basic salary");
float basic = float.Parse(Console.ReadLine());
Console.WriteLine("Enter total sale");
float ts = float.Parse(Console.ReadLine());
float net = 0;

if (basic >= 5000 && basic <= 7500)
{
    net = ((basic * 3) / 100) + basic;
}
if (basic >= 7501 && basic <= 10500)
{
    net = ((basic * 8) / 100) + basic;
}
if (basic >= 10501 && basic <= 15000)
{
    net = ((basic * 11) / 100) + basic;
}
if (basic >=15000)
{
    net = ((basic * 3) / 100) + basic;
}

Console.WriteLine("Net salary:"+net);