using System;
using System.Globalization;

namespace ExHeranca2.Entities
{
    class Circle : GeometricFigure, IArea
    {
        public double Radius { get; set; }

        public Circle(double radius, string form)
            : base(form)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ShowGeo()
        {
            return "Área do Círculo: "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
