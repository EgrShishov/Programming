using System;

namespace LabRab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Введите x : ");

            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Неправильный ввод");
            }

            Console.WriteLine("Введите y : ");

            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Неправильный ввод");
            }

            double z = Func.min(x, 2*y+x) - Func.min(7*x + 2*y,y);
            Console.WriteLine($"Ответ : {z}");
        }
    }

}