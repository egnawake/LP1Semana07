using System;

namespace ColorBallsWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Color green = new Color { R = 0, G = 255, B = 0 };
            Console.WriteLine(green.AsString);

            Ball b1 = new Ball(green, 25);
            Console.WriteLine("{0}, {1}, {2}",
                g.Color.AsString,
                g.Radius,
                g.TimesThrown);
        }
    }
}
