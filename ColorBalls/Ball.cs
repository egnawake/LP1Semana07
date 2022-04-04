namespace ColorBalls
{
    public class Ball
    {
        private Color _color;
        private int _radius;
        private int _timesThrown;

        public Ball(Color color, int radius)
        {
            _color = color;
            _radius = radius;
            _timesThrown = 0;
        }

        public void Pop()
        {
            _radius = 0;
        }

        public void Throw()
        {
            if (_radius > 0)
            {
                _timesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return _timesThrown;
        }
    }
}
