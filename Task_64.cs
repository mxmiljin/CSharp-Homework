// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int numberOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        
        Console.Write($"All integers between {numberOne} and {numberTwo} are: ");
        if (numberTwo > numberOne) 
        {
            for(int i = numberOne; i < numberTwo; i++)
            {
                Console.Write(i + ", ");
            }
        Console.Write(numberTwo + ".");
        }

        else if (numberOne > numberTwo) 
        {
            for(int i = numberTwo; i < numberOne; i++)
            {
               Console.Write(i + ", ");
            }
            Console.Write(numberOne + ".");
        }
    }
}
