Console.WriteLine("Введите ваше число:");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int fillArray = 0; // переменная нужна для заполнения массива в цикле в строках 21-28
int N1 = N; // переменная N1 нужна для выделения цифр из числа в строках 24 и 25, т.к. в результате цикла в строках 8-12 N становится равна 0. 


while (N > 0) // этот цикл подсчитывает количество цифр в вводимом числе и сохраняет в переменную count.
{
    N = N/10;
    count++;
}

int[] NewArray = new int[count];


if (count >= 3)
{
    int countTemp = count; // переменная нужна для выхода из цикла в строках 21-28, т.к. переменная count будет обнуляться там же для выделения цифр из числа. 
    
    while (fillArray < countTemp)
    {
        
        NewArray[fillArray] = N1 / Convert.ToInt32(Math.Pow(10, count - 1));
        N1 = N1 - NewArray[fillArray] * Convert.ToInt32(Math.Pow(10, count - 1));
        fillArray++;
        count--;
    }

    Console.WriteLine(NewArray[2]);
    
}

else if (count < 3)
{
    Console.WriteLine("Третьей цифры нет");
}










