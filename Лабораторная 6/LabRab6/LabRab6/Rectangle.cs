using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRab6
{
    public class Rectangle : Shape
    {
        double width, height;
        public double Width 
        {
            get { return width; }
            set { this.width = value; }
        }
        public double Height
        {
            get { return height; }
            set { this.height = value; }
        }
        public override double GetSquare()
        {
            Console.WriteLine($"{height},{width}");
            return this.width * this.height;
        }

        public override double GetPerimetr()
        {
            return 2 * (this.height + this.width);
        }
 
    }
}