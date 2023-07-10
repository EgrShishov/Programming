using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab7
{
    internal class complex
    {
        private double real, imaginary;

        public complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
            Console.WriteLine("Конструктор класса complex создан");
        }

        public double Real
        {
            set { 
                if(value.GetType()!=typeof(double))
                {
                    Console.WriteLine("Ошибка ввода");
                    throw new Exception("Ошибка ввода! Поля могут содержать только числа");
                }
                real = value;
            }
            get { return real; }
        }

        public double Imaginary
        {
            set { imaginary = value; }
            get { return imaginary; }
        }
        public static complex operator +(complex rightOperand,complex leftOperand)
        {
            return new complex((rightOperand.real + leftOperand.real),(rightOperand.imaginary+leftOperand.Imaginary));
        }

        public static complex operator +(complex rightOperand, double leftOperand)
        {
            return new complex((rightOperand.real + leftOperand), (rightOperand.imaginary));
        }

        public static complex operator -(complex rightOperand, complex leftOperand)
        {
            return new complex((rightOperand.real - leftOperand.real), (rightOperand.imaginary - leftOperand.Imaginary));
        }

        public static complex operator -(complex rightOperand, double leftOperand)
        {
            return new complex((rightOperand.real - leftOperand), (rightOperand.imaginary));
        }

        public static complex operator *(complex rightOperand, complex leftOperand)
        {
            return new complex((rightOperand.real*leftOperand.real - leftOperand.imaginary*rightOperand.imaginary),(leftOperand.real*rightOperand.imaginary + leftOperand.imaginary*rightOperand.real));
        }

        public static complex operator *(complex rightOperand, double leftOperand)
        {
            return new complex((rightOperand.real*leftOperand - leftOperand*rightOperand.imaginary), (leftOperand*rightOperand.imaginary + leftOperand*rightOperand.real));
        }

        public static complex operator /(complex rightOperand, complex leftOperand)
        {
            double div = (rightOperand.real*rightOperand.real+rightOperand.imaginary*rightOperand.imaginary);
            return new complex(((rightOperand.real*leftOperand.real+rightOperand.imaginary*leftOperand.imaginary)/div),((rightOperand.real*leftOperand.imaginary-leftOperand.real*rightOperand.imaginary)/div));
        }

        public static complex operator /(complex rightOperand, double leftOperand)
        {
            double div = (rightOperand.real*rightOperand.real+rightOperand.imaginary*rightOperand.imaginary);
            return new complex(((rightOperand.real*leftOperand+rightOperand.imaginary*leftOperand)/div), ((rightOperand.real*leftOperand-leftOperand*rightOperand.imaginary)/div));
        }

        public static bool operator true (complex Expression)
        {
            return Expression.real!=0 || Expression.imaginary!=0;
        }

        public static bool operator false (complex Expression)
        {
            return Expression.real==0 && Expression.imaginary==0;
        }

        public static complex operator ++(complex operand)
        {
            return new complex(operand.real+1, operand.imaginary);
        }

        public static complex operator --(complex operand)
        {
            return new complex(operand.real-1, operand.imaginary);
        }

        public static bool operator == (complex rightOperand,complex leftOperand)
        {
            if(leftOperand.real==rightOperand.real && leftOperand.Imaginary==rightOperand.Imaginary)
            return true;

            return false;
        }

        public static bool operator !=(complex rightOperand,complex leftOperand)
        {
            if(leftOperand.real!=rightOperand.real && leftOperand.Imaginary!=rightOperand.Imaginary)
                return true;

            return false;
        }

        public static bool operator <(complex rightOperand, complex leftOperand)
        {
            double moduleRight = Math.Sqrt(rightOperand.real*rightOperand.real+rightOperand.imaginary*rightOperand.imaginary);
            double moduleLeft = Math.Sqrt(leftOperand.real*leftOperand.real+leftOperand.imaginary*leftOperand.imaginary);
            if (moduleLeft<moduleRight)
                return true;

            return false;
        }

        public static bool operator >(complex rightOperand, complex leftOperand)
        {
            double moduleRight = Math.Sqrt(rightOperand.real*rightOperand.real+rightOperand.imaginary*rightOperand.imaginary);
            double moduleLeft = Math.Sqrt(leftOperand.real*leftOperand.real+leftOperand.imaginary*leftOperand.imaginary);
            if (moduleLeft>moduleRight)
                return true;

            return false;
        }

        public override string ToString()
        {
            string im = this.imaginary.ToString();
            string rez = this.real.ToString();
            if (Convert.ToDouble(im)<0)
                return $"{rez} {im}i";
            else if (Convert.ToDouble(im)==0)
                return $"{rez}";
            else if (Convert.ToDouble(rez)==0)
                return $"{im}i";
            else return $"{rez} + {im}i";
        }

        public complex this[int index]
        {
            get { return this[index]; }
            set { this[index]=value; }
        }

        public static explicit operator double(complex Expression) //explicit - явное преобразование
        {
            return Expression.Real;
        }

        public static implicit operator complex(double Expression) //неявное преобразование с помощью implicit
        {
            return new complex(Expression, 0);
        }

        public override bool Equals(object? obj)
        {
            if (obj.GetType()!=this.GetType())
                return false;
            if (obj == null) return false;
            complex Expr = (complex)obj;
            return this.Real*Expr.Real==this.imaginary*this.imaginary;
        }

    }

}
