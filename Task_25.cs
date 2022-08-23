using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Write("Введите первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = Convert.ToInt32(Math.Pow(number1, number2));

            Console.WriteLine(number1 + " в " + number2 + " степени равняется " + result + ".");
        }

    }
}
