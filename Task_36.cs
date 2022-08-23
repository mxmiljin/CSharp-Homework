using System;
class Program
{
    static void Main(string[] args)
    {
        int len = new Random().Next(1, 10);
        int[] array = new int[len];
        int result = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            int value = new Random().Next(-20, 20);
            array[i] = value; 
            if (array[i] % 2 != 0)
            {
                result = result + array[i];
            }
        }

        Console.WriteLine("Сумма всех нечетных чисел в массиве: " + result); 
        Console.WriteLine();
        Console.WriteLine("Если не верите, то считайте сами:");

        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.Write(array[array.Length - 1] + ".");
    }   

}
