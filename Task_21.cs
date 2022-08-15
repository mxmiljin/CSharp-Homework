using System;
class Program
{
    static void Main(string[] args)
    {
        int[] CoordinatesInput()
        {
            int[] array = new int[3];
            Console.WriteLine("по оси x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("по оси y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("по оси z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            array[0] = x; array[1] = y; array[2] = z;

            return array;
            
        }
        
        Console.Write("Введите координаты для первой точки ");
        int[] PositionA = CoordinatesInput();

        Console.Write("Введите координаты для второй точки ");
        int[] PositionB = CoordinatesInput();

        

        double result = Math.Round(Math.Sqrt(Math.Pow((PositionA[0] - PositionB[0]), 2) + Math.Pow((PositionA[1] - PositionB[1]), 2) 
                        + Math.Pow((PositionA[2] - PositionB[2]), 2)), 2);
        Console.Write("Расстояние между точками составляет " + result + ".");
        
    }
        
        


}