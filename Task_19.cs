Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int fillArray = 0; // переменная нужна для заполнения массива в цикле в строках 21-28
int N1 = N; // переменная N1 нужна для выделения цифр из числа в строках 24 и 25, т.к. в результате цикла в строках 8-12 N становится равна 0. 
int N2 = N;

while (N > 0) // этот цикл подсчитывает количество цифр в вводимом числе и сохраняет в переменную count.
{
    N = N/10;
    count++;
}

while (count != 5)
{
    Console.WriteLine("Вы ввели не пятизначное чилсло. Пожалуйста, введите пятизначное число: ");
    N = Convert.ToInt32(Console.ReadLine());
}

int[] NewArray = new int[count];
int countTemp = count;
while (fillArray < countTemp)
{
    NewArray[fillArray] = N1 / Convert.ToInt32(Math.Pow(10, count - 1));
    N1 = N1 - NewArray[fillArray] * Convert.ToInt32(Math.Pow(10, count - 1));
    fillArray++;
    count--;
}

if (NewArray[0] == NewArray [4])
{
    if (NewArray[1] == NewArray[3])
    {
        Console.WriteLine("Число " + N2 + " является палиндромом.");
    }
}
else
{
    Console.WriteLine("Число " + N2 + " не является палиндромом.");
}


    
