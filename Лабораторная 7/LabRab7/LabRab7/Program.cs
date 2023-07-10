using System;

namespace LabRab7
{

    class Program
    {
        static void Main(string[] args)
        {
            complex number = new complex(2,3);
            complex number2 = new complex(2, -3);
            

            if(number == number2)
                Console.WriteLine("equale");
            else
                Console.WriteLine("not equale");

            number++;
            number2--;
            number2+=number;

            Console.WriteLine($"Первое число {number.ToString()}");
            Console.WriteLine($"Второе число {number2.ToString()}");
            if (number == number2)
                Console.WriteLine("equale");
            else
                Console.WriteLine("not equale");

            Console.WriteLine($"Сложение двух комплексных чисел равно : {number2.ToString()}");

            number*=number2;
            Console.WriteLine($"multiplied number : {number.ToString()}");

            number/=number2;
            Console.WriteLine($"divided number : {number.ToString()}");

            complex number3 = new complex(11,-44);
            complex number4 = new complex(11,-44);
            Console.WriteLine($"Третье число {number3.ToString()}");
            Console.WriteLine($"Четвертое число {number4.ToString()}");

            complex ans = number3*number4;
            Console.WriteLine($"divided number : {ans.ToString()}");

            Console.WriteLine(number3.ToString());

            double a = 10;
            complex expr = a;
            Console.WriteLine(expr.ToString());

            Console.WriteLine(number2.ToString());
            double b = (double)number2;
            Console.WriteLine(b);

        }

    }

}
