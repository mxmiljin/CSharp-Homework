// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter first number: ");
        int one = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter second number: ");
        int two = Convert.ToInt32(Console.ReadLine());

        int result = 0;

        int Akkerman(int m, int n)
        {
            if (m == 0)
            {
                result = n + 1;
            }

            else if (m > 0 & n == 0)
            {
                result = result + Akkerman(m - 1, 1);
            }

            else if (m > 0 & n > 0)
            {
                result = result + Akkerman(m - 1, Akkerman(m, n - 1));
            }
            
            return result;
        }

        int output = Akkerman(one, two);
        Console.WriteLine(output);
    }
}
