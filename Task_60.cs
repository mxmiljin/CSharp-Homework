// ..Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

using System;
class Program
{
    static void Main(string[] args)
    {
        int[,,] array = new int[2, 2, 2];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    int value = new Random().Next(10, 99);
                    Console.Write($"{value}({i}{j}{k}) ");
                }
            }
            Console.WriteLine();
        }
    }
}

