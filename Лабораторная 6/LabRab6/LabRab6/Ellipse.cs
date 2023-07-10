using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRab6
{
    public class Ellipse : Shape
    {
        double smallSemiaxiaRadius = 0, bigSemiaxisRadius = 0;

        public double SmallRadius
        {
            set { this.smallSemiaxiaRadius=value; }
            get { return this.smallSemiaxiaRadius; }
        }

        public double BigRadius
        {
            set { this.bigSemiaxisRadius=value; }
            get { return this.bigSemiaxisRadius; }
        }
        public override double GetPerimetr()
        {
            return Math.PI*(BigRadius + SmallRadius);
        }

        public override double GetSquare()
        {
           return Math.PI*SmallRadius*BigRadius;
        }


        public void Print()
        {
            Console.WriteLine("Наша фигура - эллипс");
        }
    }
}