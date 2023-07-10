using System;
//является ли сумма цифр двухзначного числа четной
class Program
{
    static void Main(string[] args)
    {

        while(true)
        {
            Console.WriteLine("Введите число");
            int number;
            while(!int.TryParse(Console.ReadLine(),out number) || number/100!=0)
            {
                Console.WriteLine("Ошибка ввода");
            }
            if ((number/10 + number%10) % 2 == 0)
            {
                Console.WriteLine("Является");
            }
            else
            {
                Console.WriteLine("Не является");
            }

            Console.WriteLine("Введите 0,чтобы продолжить, и 1 - чтобы закончить");
            int choice;
            while(!int.TryParse(Console.ReadLine(),out choice) || choice<0 || choice>1)
            {
                Console.WriteLine("Ошибка ввода");
            }
            bool flag = false;

            switch (choice)
            {
                case 0:
                    flag=true;
                    break;
                    
                default:
                    break;
            }

            if (!flag) break;

        }

    }
}
