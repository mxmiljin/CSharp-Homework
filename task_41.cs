//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите любое количество чисел через запятую: ");
        string numbers = Convert.ToString(Console.ReadLine());

        void StringToIntArray(string arr)
        {
            char[] separators = new char[] {' ', ','};

            string[] subs =  arr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            foreach (var sub in subs)
            {
                i++; 
            }

            int[] NumbersArray = new int[i];

            i = 0;

            string[] results =  arr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
           
            foreach (var result in results)
                {
                    NumbersArray[i] = Convert.ToInt32(result);
                    i++;
                }
                
            int count = 0;
            for (int x = 0; x < i; x++)
            {
               if (NumbersArray[x] > 0)
               {
                    count++;
               } 
            }
            
            Console.WriteLine($"Количество чисел больше нуля: {count}.");
            

        }
        StringToIntArray(numbers);

    }
}
