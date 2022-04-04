namespace ColorBalls
{
    public class Color
    {
        private byte _r;
        private byte _g;
        private byte _b;
        private byte _a;

        public Color(byte r, byte g, byte b, byte a)
        {
            _r = r;
            _g = g;
            _b = b;
            _a = a;
        }

        public Color(byte r, byte g, byte b)
        {
            _r = r;
            _g = g;
            _b = b;
            _a = 255;
        }

        public byte GetRed()
        {
            return _r;
        }

        public byte GetGreen()
        {
            return _g;
        }

        public byte GetBlue()
        {
            return _b;
        }

        public byte GetAlpha()
        {
            return _a;
        }
    }
}
