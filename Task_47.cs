//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
class Program
{
    static void Main(string[] args)
    {
        double[,] Array = new double [5, 4];

        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                double number = new Random().NextDouble();
                double number1 = new Random().Next(-10, 10);
                Array[i, j] = Math.Round(number * number1, 1);
                Console.Write(Array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
