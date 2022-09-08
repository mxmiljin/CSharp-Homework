// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
class Program
{
    static void Main(string[] args)
    {
        int row = new Random().Next(0, 10);
        int col = new Random().Next(0, 10);
        int[,] NewArray = new int[row, col];
        double mean = 0;
        
        // Цикл для заполнения массива случайными числами от 1 до 9 и вывода массива на экран
        for (int i = 0; i < NewArray.GetLength(0); i++)
        {
            for (int j = 0; j < NewArray.GetLength(1); j++)
            {
                NewArray[i, j] = new Random().Next(0, 10); 
                Console.Write(NewArray[i, j] + " "); 
            }
            Console.WriteLine();
        }     

        // Цикл для подсчета и вывода среднего арифметического по столбцам
        for (int j = 0; j < NewArray.GetLength(1); j++)
        {
            for (int i = 0; i < NewArray.GetLength(0); i++)
            {
                mean = mean + NewArray[i, j];
            }
            Console.WriteLine($"Среднее арифметическое в столбце { j + 1 } равняется { Math.Round(mean / row , 1) }. ");
            mean = 0;
        }
    }
}
