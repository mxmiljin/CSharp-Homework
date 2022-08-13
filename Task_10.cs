using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число:");
        int N = Convert.ToInt32(Console.ReadLine());

        int figure1 = N / 100;
        int figure2 = (N - figure1*100) / 10;
        int figure3 = N - figure1*100 - figure2*10;

        int[] NewArray = {figure1, figure2, figure3};
        Console.Write("Вторая цифра в числе: " + NewArray[1]);
    }
}
