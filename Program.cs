// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
string a = Console.ReadLine();
int b = a.Length;


if (b == 5)
{
    if (a[0] == a[4] && a[1] == a[3])
        Console.WriteLine($"является палиндромом: {a}");

    else
        Console.WriteLine($"Не является палиндромом: {a}");


}
else
    Console.WriteLine($"Вы ввели не пятизначное число: {a}!");


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.WriteLine("Введите координт точки x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координт точки y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координт точки z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координт точки x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координт точки y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координт точки z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)), 3));



// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Таблица кубов: ");

for (int i = 1; i <= a; i++)
    Console.Write(i * i * i + " ");
