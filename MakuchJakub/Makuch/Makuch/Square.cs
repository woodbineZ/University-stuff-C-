namespace Makuch
{
    internal class Square : Shape
    {
        private double _side;
        public double Side //set i get w przypadku nieodpowiednich wartosci side
        {
            get
            {
                return _side;
            }
            private set
            {
                if (_side > 0)
                    _side = value;
            }
        }
        public Square(double d) //Konstruktor klasy Square
        {
            Name = "Kwadrat";
            _side = d;
        }
        public override double GetArea() //Metoda abstrakcyjna nadpisujaca sposob wywolania metody GetArea dla kwadratu
        {
            return Side * Side;
        }
    }
}