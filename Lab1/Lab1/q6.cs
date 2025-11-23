using System;

namespace q6
{

    interface IShape
    {
        void GetDimensions();
    }

    interface ICalculate
    {
        void CalculateArea();
    }

    class Rectangle : IShape, ICalculate
    {
        int length;
        int breadth;
        int area;

        public void GetDimensions()
        {
            Console.Write("Enter length: ");
            length = int.Parse(Console.ReadLine());

            Console.Write("Enter breadth: ");
            breadth = int.Parse(Console.ReadLine());
        }

        public void CalculateArea()
        {
            area = length * breadth;
            Console.WriteLine("Area of Rectangle = " + area);
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle rect = new Rectangle();

            rect.GetDimensions();     // From IShape
            rect.CalculateArea();     // From ICalculate
        }
    }
}
