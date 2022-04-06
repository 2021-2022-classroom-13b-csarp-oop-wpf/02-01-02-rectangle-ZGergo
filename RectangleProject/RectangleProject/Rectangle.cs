using System;

namespace RectangleProject
{
    public class Rectangle
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public Rectangle(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }

        public double Area { get { return SideA * SideB; } }

        public double Perimeter { get { return 2 * SideA + 2 * SideB; } }

        public override string ToString()
        {
            return "A oldal: " + SideA + "\n" +
                "B oldal: " + SideB + "\n" +
                "Kerület: " + Math.Round(Area, 2) + "\n" +
                "Terület: " + Math.Round(Perimeter, 2) + "\n";
        }
    }
}
