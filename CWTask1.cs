using System;

public class HelloWorld
{
    
    struct Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Plo()
        {
            return Length * Width;
        }

        public double Per()
        {
            return 2 * (Length + Width);
        }

        public static void SravRectangles(Rectangle rect1, Rectangle rect2)
        {

            if (rect1.Length > rect2.Length)
            {
                Console.WriteLine("Rectangle 1 длиннее Rectangle 2");
            }
            else if (rect1.Length < rect2.Length)
            {
                Console.WriteLine("Rectangle 2 длиннее Rectangle 1");
            }
            else
            {
                Console.WriteLine("Rectangle 1 и Rectangle 2 одинаковы по длине");
            }

            if (rect1.Width > rect2.Width)
            {
                Console.WriteLine("Rectangle 1 шире Rectangle 2.");
            }
            else if (rect1.Width < rect2.Width)
            {
                Console.WriteLine("Rectangle 2 шире Rectangle 1.");
            }
            else
            {
                Console.WriteLine("Rectangle 1 и Rectangle 2 одинаковы по ширине");
            }

            double area1 = rect1.Plo();
            double area2 = rect2.Plo();

            if (area1 > area2)
            {
                Console.WriteLine("Площадь Rectangle 1 больше площади Rectangle 2");
            }
            else if (area1 < area2)
            {
                Console.WriteLine("Площадь Rectangle 2 больше площади Rectangle 1");
            }
            else
            {
                Console.WriteLine("Площадь Rectangle 1 и площадь Rectangle 2 имееют одинаковую площадь");
            }
            Console.WriteLine();
        }
    }

class Program
{
    static void Main()
    {
        Rectangle rect1 = new Rectangle(5, 8);
        Rectangle rect2 = new Rectangle(6, 10);
        Rectangle rect3 = new Rectangle(5, 10);

        Rectangle.SravRectangles(rect1, rect2);
        Rectangle.SravRectangles(rect2, rect3);
        Rectangle.SravRectangles(rect1, rect3);
    }
}
}