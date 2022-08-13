using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число от 1 до 7:");

        int inputNumber = Convert.ToInt32(Console.ReadLine());
        int[] ArrayDays = {1, 2, 3, 4, 5, 6, 7};
        int Count = 0;

        while (inputNumber > 7)
        {
            Console.WriteLine("Введите число от 1 до 7:");
            inputNumber = Convert.ToInt32(Console.ReadLine());
        } 

        if (inputNumber < 6)
        {
            Console.WriteLine(inputNumber + " - это рабочий день.");
        }
        else if(inputNumber > 5)
        {
            Console.WriteLine(inputNumber + " - это выходной день.");
        }   
    }
}
