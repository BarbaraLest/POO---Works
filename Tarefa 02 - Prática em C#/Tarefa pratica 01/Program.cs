using System;

namespace Tarefa_pratica_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c = new Circulo();
            Console.Write("Digite o raio da circunferencia: ");
            c.raio = Convert.ToDouble(Console.ReadLine());

            double resultado = c.Area(c.raio);
            Console.WriteLine(resultado);

            double resultado2 =  c.Comprimento(c.raio);
            Console.WriteLine(resultado2);

            Console.ReadKey();



        }
    }
}
