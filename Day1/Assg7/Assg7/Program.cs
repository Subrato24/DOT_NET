// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Basic salary");
float basic = int.Parse(Console.ReadLine());

float HRA = ((basic * 20) / 100) + basic;

float DA = ((basic * 40) / 100) + basic;

float PF = ((basic * 10) / 100) + basic;

float gross = HRA + DA + PF;
float net = gross - PF;

Console.WriteLine("gross salary" + gross);
Console.WriteLine("net salary" + net);