namespace ColorBallsWithProperties
{
    public class Color
    {
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public byte A { get; set; } = 255;

        public byte GrayLevel => (byte) ((R + G + B) / 3);

        public string AsString => $"({R}, {G}, {B}, {A})";
    }
}
