using System;
class Program
{
    static void Main(string[] args)
    {
        void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.Write(arr[arr.Length - 1] + ".");
            Console.WriteLine();
        }

        int[] array = new int[new Random().Next(1,20)];
        int[] result = new int[array.Length/2];
        
        
        for (int i = 0; i < array.Length; i++)
        {
            int value = new Random().Next(1, 10);
            array[i] = value; 
        }

        PrintArray(array);


        for (int k = 0; k < result.Length; k++)
        {
            int mult = array[k] * array[array.Length - 1 - k];
            result[k] = mult;
        }
        Console.WriteLine();
        PrintArray(result);

    }   
}
