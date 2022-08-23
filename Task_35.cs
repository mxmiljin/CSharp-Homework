using System;
class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        int count = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            int value = new Random().Next(1, 123);
            array[i] = value; 
            if (array[i] > 10 & array[i] < 100)
            {
                count++;
            }
        }

        Console.WriteLine("Количество числел в диапазоне от 10 до 99: " + count); 
        Console.WriteLine();
        Console.WriteLine("Ладно, тут самим можно не считать, поверьте на слово...");


    }   
}
