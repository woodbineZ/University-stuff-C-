using System;
namespace Makuch
{
    internal class Circle : Shape
    {
        private double Radius;
        public double _Radius
        {
            get
            {
                return Radius;
            }
            set
            {
                if (value > 0)
                    Radius = value;
                else
                    Radius = 0;
            }
        }
        public Circle(double r)  // konstruktor klasy Circle
        {
            Name = "Koło";
            Radius = r;
        }
        public override double GetArea() //Metoda abstrakcyjna nadpisujaca sposob wywolania metody GetArea dla kola
        {
            return System.Math.PI * Radius * Radius;
        }
    }
}
