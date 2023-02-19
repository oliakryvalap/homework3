// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Сonsole.WriteLine("Введите пятизначное число");
string example = Console.ReadLine(10000,100000);
int a = Convert.ToInt32(Console.ReadLine(example));
int b = Convert.ToInt32(Console.ReadLine(example));
int c = Convert.ToInt32(Console.ReadLine(example));
int d = Convert.ToInt32(Console.ReadLine(example));
int e = Convert.ToInt32(Console.ReadLine(example));

If (a == e, && b == d)
Console.WriteLine($"полиндром {a}{b}{c}{d}{e}");
else
Console.WriteLine("Не полиндром");


