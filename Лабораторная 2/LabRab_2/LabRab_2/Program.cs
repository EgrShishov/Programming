using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int x, y;
            Console.WriteLine("Введите x : ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка ввода!");
            }
            //int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y : ");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Ошибка ввода!");
            }
            //int y = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(x) <= y && x*x + y*y <=15*15)
            {
                if (Math.Abs(x) == y || x*x + y*y == 15*15)
                    Console.WriteLine("На границе");
                else
                    Console.WriteLine("Да");
            }
            else
                Console.WriteLine("Нет");


            Console.WriteLine("Введите 0,чтобы продолжить, 1 - чтобы закончить");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice<0 || choice>1)
            {
                Console.WriteLine("Ошибка ввода");
            }
            bool flag = false;

            switch(choice)
            {
                case 0:
                    flag=true;
                    break;
                default: break;

            }

            if (!flag) break;
        }

    }
}