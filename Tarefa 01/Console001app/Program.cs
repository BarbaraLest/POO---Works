using System;
using Console001app.Modelo;

namespace Console001app
{
    class Program
    {
        static void Main(string[] args)
        {
            Servico s = new Servico();

            System.Console.Write("Digite o nome do produto: ");
            s.Nome = System.Console.ReadLine();

            System.Console.Write("Digite o valor do produto: ");
            s.Valor = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();


        }
    }
}
