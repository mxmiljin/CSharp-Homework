//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше число:");
        int input = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        int output = 0;

        Console.WriteLine("Кубические степени от 1 до " + input + " включительно: ");
        while (count < input)
        {
            output = Convert.ToInt32(Math.Pow(count, 3));
            count++;
            Console.Write(output);
            Console.Write(", ");
        }
        output = Convert.ToInt32(Math.Pow(count, 3));
        Console.Write(output);
        Console.Write(".");
    }
}
