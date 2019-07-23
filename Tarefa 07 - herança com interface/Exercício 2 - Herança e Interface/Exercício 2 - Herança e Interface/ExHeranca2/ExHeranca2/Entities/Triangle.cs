using System.Globalization;

namespace ExHeranca2.Entities
{
    class Triangle : GeometricFigure, IArea
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double _base, double height, string form)
            : base(form)
        {
            Base = _base;
            Height = height;
        }

        public double Area()
        {
            return (Base * Height) / 2;
        }

        public override string ShowGeo()
        {
            return "Área do Triângulo: "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
