using System;

namespace CalculateSquareLibrary
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle : IShape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public string IsRectangle()
        {
            // Check if the triangle satisfies the Pythagorean theorem
            if (Math.Pow(Side1, 2) + Math.Pow(Side2, 2) == Math.Pow(Side3, 2) ||
                Math.Pow(Side2, 2) + Math.Pow(Side3, 2) == Math.Pow(Side1, 2) ||
                Math.Pow(Side1, 2) + Math.Pow(Side3, 2) == Math.Pow(Side2, 2))
            {
                return "The triangle is rectangular";
            }
            return "The triangle is not rectangular";
        }
        public double GetArea()
        {
            double HalfSumSides = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(HalfSumSides * (HalfSumSides - Side1) * (HalfSumSides - Side2) * (HalfSumSides - Side3));
        }
    }

    public class ShapeAreaCalculator 
    {
        double[] values { get; set; }

        public ShapeAreaCalculator(double[] value) 
        {
            values = value;
        }

        public void CalculateSquare() 
        {
            switch (values.Length) 
            {
                case 1:
                    Circle circle = new Circle { Radius = values[0] };
                    circle.GetArea();
                    break;
                case 3:
                    Triangle triangle = new Triangle {Side1 = values[0], Side2 = values[1], Side3 = values[2] };
                    triangle.GetArea();
                    break;
                default:
                    Console.WriteLine("You entered wrong quantity numbers in array");
                    break;
            }
        }
    }
}
