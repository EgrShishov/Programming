using System;

namespace LabRab6
{

    class Program
    {
        static void Main(string[] args)
        {
        Rectangle figure = new Rectangle();

            figure.Width = 20;
            figure.Height = 40;

            Console.WriteLine($"Square of figure = {figure.GetSquare()} ");
            Console.WriteLine($"Perimnetr of figure = {figure.GetPerimetr()} ");

            Circle circle = new Circle();

            circle.Radius = 10;

            circle.Print();
        }
    }

    class Class
    {
        private int x, y;
        public Class(int x, int y) { this.x = x; this.y = y; }
        public static bool operator > (Class a, Class b) { return a.x > b.x; }
    }
}
