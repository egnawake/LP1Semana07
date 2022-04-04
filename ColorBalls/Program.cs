using System;

namespace ColorBalls
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // create colors
            Color red = new Color(255, 0, 0);
            Color yellow = new Color(255, 255, 0);
            Color cyan = new Color(0, 255, 255);

            // create balls
            Ball ballOne = new Ball(red, 5);
            Ball ballTwo = new Ball(yellow, 10);
            Ball ballThree = new Ball(cyan, 20);

            // do things to balls
            ballTwo.Throw();
            ballTwo.Throw();

            ballOne.Throw();

            ballThree.Throw();
            ballThree.Pop();
            ballThree.Throw();

            // print balls states
            Console.WriteLine("Ball One");
            PrintBall(ballOne);
            Console.WriteLine("");

            Console.WriteLine("Ball Two");
            PrintBall(ballTwo);
            Console.WriteLine("");

            Console.WriteLine("Ball Three");
            PrintBall(ballThree);
            Console.WriteLine("");
        }

        private static void PrintBall(Ball ball)
        {
            Console.WriteLine("Radius: {0}, color: {1}, times thrown: {2}",
                ball.GetRadius(),
                ball.GetColor().AsString(),
                ball.GetTimesThrown()
            );
        }
    }
}
