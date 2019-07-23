using Exemplo.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Caneca caneca = new Caneca();
            
           Console.WriteLine("O preço do café para a caneca é: " + caneca.Custo(200.00) + "$");
            Console.ReadKey();
        }
    }
}
