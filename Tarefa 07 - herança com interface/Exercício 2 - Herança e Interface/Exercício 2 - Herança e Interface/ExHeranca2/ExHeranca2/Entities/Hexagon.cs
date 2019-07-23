using System;
using System.Globalization;

namespace ExHeranca2.Entities
{
    class Hexagon : GeometricFigure, IArea
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Hexagon(double _base, double height, string form)
            : base(form)
        {
            Base = _base;
            Height = height;
        }

        public double Area()
        {
            return (3 * (Base * Height) * (Base * Height) * Math.Sqrt(3)) / 2;
        }

        public override string ShowGeo()
        {
            return "Área do Hexágono: "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
