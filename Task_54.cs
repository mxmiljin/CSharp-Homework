// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] Array = new int [5, 4];

        Console.WriteLine("Исходный массив:");

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

        void PrintRegularArray(int[,] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    for (int j = 0; j < arr.GetLength(1) - 1; j++)
                    {
                        if (arr[i, j] < arr[i, j + 1])
                        {
                            temp = arr[i, j + 1];
                            arr[i, j + 1] = arr[i, j];
                            arr[i, j] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            
        }

        Console.WriteLine();
        Console.WriteLine("Упорядоченный массив: ");
        PrintRegularArray(Array);
    }
}


    
