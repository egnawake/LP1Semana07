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

        public void SetRed(byte value)
        {
            _r = value;
        }
        
        public void SetGreen(byte value)
        {
            _g = value;
        }
        
        public void SetBlue(byte value)
        {
            _b = value;
        }
        
        public void SetAlpha(byte value)
        {
            _a = value;
        }

        public byte GetGrayLevel()
        {
            int result = (GetRed() + GetGreen() + GetBlue()) / 3;
            return (byte) result;
        }
    }
}
