using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите ваше число: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        if (Number < 0)
        {
            Number = Number * -1;
        }

        string NumberString = Convert.ToString(Number);
        int result = 0;
        

        for (int i = 0; i < NumberString.Length; i++)
        {
            int Figure = Convert.ToInt32(NumberString[i]);
            result = result + Figure - 48;   
            // я не понимаю почему, но результат получается всегда на 48 больше, чем то, что должно получиться, 
            //поэтому пришлось ввести магическое число(((
        }

        Console.WriteLine("Сумма цифр в введенном вами числе: " + result);
    }
}
