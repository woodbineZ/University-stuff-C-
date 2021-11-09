using System;
using System.Collections.Generic;
using System.Text;

namespace Makuch
{
    abstract class Shape
    {
        public string Name { get; set; }
        public abstract double GetArea(); // deklaracja metody abstrakcyjnej z ktorej beda korzystaly obiekty z dziedziacych klas po klasie Shape
    }
}
