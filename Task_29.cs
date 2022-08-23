using System;

class Program
{
    static void Main(string[] args)
    {
        
        int Length = new Random().Next(1, 20);
        int[] NewArray = new int[Length];

        for (int i = 0; i < Length; i++)
        {
            int Value = new Random().Next(1, 100);
            NewArray[i] = Value;
            Console.Write(NewArray[i] + ", ");
            if (i == Length - 1)
            {
                Console.Write(NewArray[i]+ ".");
            }
        }

         
    }
}
