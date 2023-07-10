using System;

namespace LabRab3_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            double z;
            Console.WriteLine("Введите z");

            while(!double.TryParse(Console.ReadLine(),out z))
            {
                Console.WriteLine("Ошибка ввода");
            }

            Func func = new Func();
            func.y(z);
        }
    }
}