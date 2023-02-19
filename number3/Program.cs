// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
static int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Task_01()
{
    Console.Clear();
    int userNumber = Prompt("Введите номер четверти");
    switch (userNumber)
    {
     
     case 1:
     System.Console.WriteLine("Координаты x>0 и y>0");
     break;

     case 2:
     System.Console.WriteLine("Координаты x<0 и y>0");
     break;

     case 3:
     System.Console.WriteLine("Координаты x<0 и y<0");
     break;

     case 4:
     System.Console.WriteLine("Координаты x>0 и y<0");
     break;

     default:
     System.Console.WriteLine("Четверть не найдена");
     break;

    }
}

static void Task_02()
    {
        Console.Clear();
        int userNumber = Prompt("Введите число больше 0");

        for (int i = 1; i <= userNumber; i++)
        {
            System.Console.Write($"{i*i*i}\t");
        }

    }
