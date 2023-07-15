int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
int Task = Input("Введите номер задачи(1,2 или 3): ");
switch (Task)
{
    case 1:
        Task1();
        break;
    case 2:
        Task2();
        break;
    case 3:
        Task3();
        break;
    default:
        Console.WriteLine("Такого задания нет");
        break;
}

// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

void Task1()
{
    int num = Input("Введите пятизначное число: ");

    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;

    if (num < 10000 || num > 100000)
    {
        Console.WriteLine("Введено не пятизначное число");
    }
    else
    {
        if (num1 == num5 && num2 == num4)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
}

// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

void Task2()
{
    int x1 = Input("Введите x1: ");
    int x2 = Input("Введите x2: ");
    int y1 = Input("Введите y1: ");
    int y2 = Input("Введите y2: ");
    int z1 = Input("Введите z1: ");
    int z2 = Input("Введите z2: ");

    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)
                    + Math.Pow(z2 - z1, 2));
    result = Math.Round(result, 2);

    Console.WriteLine(result);
}

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

void Task3()
{
    int num = Input("Введите число: ");

    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i}^3 = {i * i * i}");
    }
}

