using System;

namespace _253502_Shishov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число : ");
            int b = Convert.ToInt32(Console.ReadLine());

            double result = (double)a / b;
            Console.Write("Ответ : ");
            Console.Write(result);
        }
    }
}


