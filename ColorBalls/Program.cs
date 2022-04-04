using System;

namespace ColorBalls
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color c = new Color(10, 20, 10, 255);
            Console.WriteLine($"{c.GetGrayLevel()}");
        }
    }
}
