namespace ColorBalls
{
    public class Ball
    {
        private readonly Color _color;
        private int _radius;
        private int _timesThrown;

        public Ball(Color color, int radius)
        {
            _color = color;
            _radius = radius;
            _timesThrown = 0;
        }

        public Color GetColor()
        {
            return _color;
        }

        public int GetRadius()
        {
            return _radius;
        }
        
        public int GetTimesThrown()
        {
            return _timesThrown;
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

    }
}
