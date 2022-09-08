// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Исходный массив:");
int[,] Array = new int[5, 5];

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        int number = new Random().Next(0,10);
        Array[i, j] = number;
        Console.Write(Array[i, j] + " ");
    }
     Console.WriteLine();
}

int result = 0;
int max = 0;
int maxLine = 0;
for (int i = 0; i < Array.GetLength(0); i++)
{   
    
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        result = result + Array[i, j];
    }
    if (result > max)
    {
        max = result;
        maxLine =  i + 1;
    }
    
    result = 0;

}

 Console.WriteLine($"Наибольшая сумма элементов находится в {maxLine} строке.");

