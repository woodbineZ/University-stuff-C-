namespace Makuch
{
    internal class Block : IBlock
    {
        public Shape Base { get; set; }
        public double Height { get; set; }
        public Block() : this(null, 0) //poczatek lancucha konstruktorow
        {
        }
        public Block(Shape b) : this(b, 0)
        {
        }
        public Block(double h) : this(null, h)
        {
        }
        public Block(Shape b, double h) //koniec lancucha konstroktorow
        {
            Base = b;
            Height = h;
        }
        public double GetVolume() //zwraca objetosc bloczka
        {
            return Base.GetArea() * Height;
        }
        public static string HowBig(double v) // statyczna funkcja oceniajaca objetosc bloczkow
        {
            if (v < 25)
                return "Your block is tiny";
            if (v > 25 && v < 75)
                return "Your block is medium";
            else
                return "Your block is huge";
        }
        public string info(double v, double h)
        {
            return $"Volume '{v}' and Height {h}";
        }
        public override string ToString()
        {
            return $"Block specifics. Block base: '{Base.Name}' Base area: '{Base.GetArea()}' Height: '{Height}' Volume: '{GetVolume()}' Block analysis: '{HowBig(GetVolume())}'";
        }
    }
}



