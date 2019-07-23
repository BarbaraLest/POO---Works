using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaPraticaMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            System.Console.Write("Insira quantos clientes deseja cadastrar:");
            var info = new Cadastro(
                System.Convert.ToInt16(System.Console.ReadLine));
        }
    }
}
