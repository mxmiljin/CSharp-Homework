Console.WriteLine("Введите ваше число:");
int Number1 = Convert.ToInt32(Console.ReadLine());
int StartNumber = 1;

if (Number1 <= StartNumber)
{
    Console.WriteLine("Четных чисел в этом диапазоне нет...");
}

else if (Number1 > StartNumber)
{
    Console.WriteLine("Четные числа в вашем диапазоне: ");
    while (StartNumber <= Number1)
    {
        if (StartNumber % 2 == 0)
        {
            Console.Write(StartNumber);
            Console.Write(", ");
        }
        StartNumber += 1;
    }
}