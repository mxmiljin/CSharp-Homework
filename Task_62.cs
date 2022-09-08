// Напишите программу, которая заполнит спирально массив 4 на 4.

using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[4, 4];

        int i = 0;
        int j = 0;
        int count = 1;
        int turn = 0;
    
        
        while (turn <= array.GetLength(0)/2)
        {
            while (j < array.GetLength(0) - turn)
                {
                    array[i,j] = count;
                    count++;
                    j++;
                }
            j = array.GetLength(0) - 1 - turn;
            count--;

            while (i < array.GetLength(1) - turn)
                {
                    array[i,j] = count;
                    count++;
                    i++;
                }
            i = array.GetLength(1) - 1 - turn;
            count--;

            while (j >= 0 + turn)
                {
                    array[i,j] = count;
                    count++;
                    j--;
                }
            j = turn;
            count--;
            turn++;

            while (i >= 0 + turn)
                {
                    array[i,j] = count;
                    count++;
                    i--;
                }
            i = turn;
            count--;
        }
        
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(0); y++)
        {
            Console.Write(array[x, y] + " ");
        }
    Console.WriteLine();
    }
    }
}

