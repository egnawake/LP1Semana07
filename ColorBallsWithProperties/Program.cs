using System;

namespace ColorBallsWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Color green = new Color { R = 0, G = 255, B = 0 };
            Color darkPurple = new Color { R = 127, G = 0, B = 127 };
            Console.WriteLine(green.AsString);

            Ball b1 = new Ball(green, 25);
            Console.WriteLine("{0}, {1}, {2}",
                b1.Color.AsString,
                b1.Radius,
                b1.TimesThrown);

            Console.WriteLine($"{green.Name}");
            Console.WriteLine($"{darkPurple.Name}");
        }
    }
}
