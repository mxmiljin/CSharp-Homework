using System;
class Program
{
    static void Main(string[] args)
    {
        int len = new Random().Next(1, 20);
        double[] array = new double[len];
        double min = 10;
        double max = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            double value = new Random().Next(-10, 10);
            array[i] = value; 
            if (max < array[i])
            {
                max = array[i];                
            }
            if (min > array[i])
            {
                min = array[i];
            }
        }
        double result = max - min;
        Console.WriteLine("Разница между минимальным и максимальным числами массива: " + result); 
        Console.WriteLine();
        Console.WriteLine("Если не верите, то считайте сами:");

        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.Write(array[array.Length - 1] + ".");
    }   

}
