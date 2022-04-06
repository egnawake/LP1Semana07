namespace ColorBallsWithProperties
{
    public class Ball
    {
        public Color Color { get; }
        public int TimesThrown { get; private set; } = 0;
        public int Radius { get; private set; }

        public Ball(Color color, int radius)
        {
            Color = color;
            Radius = radius;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
            {
                TimesThrown++;
            }
        }
    }
}
