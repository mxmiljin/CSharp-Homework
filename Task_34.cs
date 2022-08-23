using System;
class Program
{
    static void Main(string[] args)
    {
        int len = new Random().Next(1, 20);
        int[] array = new int[len];
        int count = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            int value = new Random().Next(100, 999);
            array[i] = value; 
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество четных числел в случайном массиве: " + count); 
        Console.WriteLine();
        Console.WriteLine("Если не верите, то считайте сами:");

        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.Write(array[array.Length - 1] + ".");
    }   

}
