using System.Globalization;

namespace ExHeranca2.Entities
{
    class Rectangle : GeometricFigure, IArea
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, string form)
            : base(form)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }

        public override string ShowGeo()
        {
            return "Área do Retângulo: "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
