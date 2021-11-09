using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makuch
{
    internal class Rectangle : Shape
    {
        private double sideA;
        private double sideB;
        public double _sideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                if (value > 0)
                    _sideA = value;
                else
                    _sideA = 0;
            }
        }
        public double _sideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                if (value > 0)
                    _sideB = value;
                else
                    _sideB = 0;
            }
        }
        public Rectangle(double _sideA, double _sideB) // konstruktor klasy Rectangle
        {
            Name = "Prostokat";
            sideA = _sideA;
            sideB = _sideB;
        }
        public override double GetArea() //Metoda abstrakcyjna nadpisujaca sposob wywolania metody GetArea dla prostokata
        {
            return sideA * sideB;
        }
    }
}
