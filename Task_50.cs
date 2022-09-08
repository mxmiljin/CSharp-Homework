//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] Array = new int [5, 4];

        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                int number = new Random().Next(0,10);
                Array[i, j] = number;
                Console.Write(Array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.Write("Введите номер строки: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер колонки: ");
        int col = Convert.ToInt32(Console.ReadLine());

        if (row <= Array.GetLength(0) & col <= Array.GetLength(1))
        {
            Console.WriteLine($"Элемент с координатами {row} и {col}: {Array[row - 1, col - 1]}.");
        }
        else if(row > Array.GetLength(0) | col > Array.GetLength(1))
        {
            Console.WriteLine("Элемента с такими координатами нет.");
        }

    }
}
