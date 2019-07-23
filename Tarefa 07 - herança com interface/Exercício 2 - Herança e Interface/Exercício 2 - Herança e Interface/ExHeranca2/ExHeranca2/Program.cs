using System;
using ExHeranca2.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExHeranca2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GeometricFigure> geo = new List<GeometricFigure>();

            Console.Write("Quantas figuras geométricas deseja cadastrar?: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("OPÇÕES:");
                Console.WriteLine();
                Console.WriteLine("[1] - Círculo");
                Console.WriteLine("[2] - Hexágono");
                Console.WriteLine("[3] - Retângulo");
                Console.WriteLine("[4] - Trapézio");
                Console.WriteLine("[5] - Triângulo");
                Console.Write("Qual figura geométrica deseja cadastrar?: ");
                int ac = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (ac)
                {
                    case 1:
                        Console.WriteLine("DADOS DO CÍRCULO:");
                        Console.WriteLine();
                        Console.Write("Raio: ");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        geo.Add(new Circle(radius, "Circle"));
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("DADOS DO HEXÁGONO:");
                        Console.WriteLine();
                        Console.Write("Base: ");
                        double _baseH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Altura: ");
                        double heightH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        geo.Add(new Hexagon(_baseH, heightH, "Hezagon"));
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("RETÂNGULO:");
                        Console.WriteLine();
                        Console.Write("Largura: ");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Altura: ");
                        double heightR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        geo.Add(new Rectangle(width, heightR, "Rectangle"));
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("TRAPÉZIO:");
                        Console.WriteLine();
                        Console.Write("Base Maior: ");
                        double largeBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Base Menor: ");
                        double minorBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Altura: ");
                        double heightTra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        geo.Add(new Trapezium(largeBase, minorBase, heightTra, "Trapezium"));
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine("TRIÂNGULO:");
                        Console.WriteLine();
                        Console.Write("Base: ");
                        double _baseT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Altura: ");
                        double heightT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        geo.Add(new Triangle(_baseT, heightT, "Triangle"));
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine();
                        break;
                }
            }

            Console.WriteLine("FIGURAS GEOMÉTRICAS:");
            foreach (GeometricFigure geoFigure in geo)
            {
                Console.WriteLine();
                Console.WriteLine(" - " + geoFigure.ShowGeo());
            }

            Console.ReadKey();
        }
    }
}