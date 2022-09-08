using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] ArrayOne = {{2, 4}, {5, 12}};
        int[,] ArrayTwo = {{5, 7}, {4, 6}};

        int[,] ArrayResult = new int[2, 2];

        for (int i = 0; i < ArrayResult.GetLength(0); i++)
        {
            for (int j = 0; j < ArrayResult.GetLength(1); j++)
            {
                ArrayResult[i, j] = ArrayOne[i, j] * ArrayTwo[i, j];
                Console.Write(ArrayResult[i, j] + " ");
            }
            Console.WriteLine();  
        }
    }
}
