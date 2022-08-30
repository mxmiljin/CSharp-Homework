// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое значение для первой прямой: ");
        double k1 = Convert.ToDouble(Console.ReadLine());   

        Console.Write("Введите второе значение для первой прямой: "); 
        double b1 = Convert.ToDouble(Console.ReadLine());  

        Console.Write("Введите первое значение для второй прямой: ");
        double k2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе значение для второй прямой: ");
        double b2 = Convert.ToDouble(Console.ReadLine());


        double x = Math.Round((b1 - b2)/(k2 - k1), 2);
        double y = Math.Round(k2 * x + b2, 2);

        Console.WriteLine($"Координаты точки пересечения прямых по оси х: {x} по оси у: {y}."); 
    }


}
