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

        public string Name => this switch
        {
            { R: 255, G: 0, B: 0 } => "Red 100%",
            { R: 0, G: 255, B: 0 } => "Green 100%",
            { R: 0, G: 0, B: 255 } => "Blue 100%",
            _ => "Mixed"
        };
    }
}
