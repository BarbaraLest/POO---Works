using System.Globalization;

namespace ExHeranca2.Entities
{
    class Trapezium : GeometricFigure, IArea
    {
        public double LargeBase { get; set; }
        public double MinorBase { get; set; }
        public double Height { get; set; }

        public Trapezium(double largeBase, double minorBase, double height, string form)
            : base(form)
        {
            LargeBase = largeBase;
            MinorBase = minorBase;
            Height = height;
        }

        public double Area()
        {
            return ((LargeBase + MinorBase) * Height) / 2;
        }

        public override string ShowGeo()
        {
            return "Área do Trapézio: "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
