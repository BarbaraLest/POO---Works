using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico h = new Historico();
            Console.Write("Digite o nome do aluno: ");
            h.Nome = Console.ReadLine();

            Console.Write("Digite as notas do aluno: ");
            h.Nota1 = Convert.ToDouble(Console.ReadLine());
                      
            h.Nota2 = Convert.ToDouble(Console.ReadLine());

            h.Nota3 = Convert.ToDouble(Console.ReadLine());

            h.Nota4 = Convert.ToDouble(Console.ReadLine());

            double media = h.Media(h.Nota1, h.Nota2, h.Nota3, h.Nota4);
            Console.WriteLine("O aluno " + h.Nome + " possui média " + media );

            string  aprovacao = h.Aprovacao(h.media);
            Console.WriteLine("Situação: " + aprovacao);

            Console.ReadKey();
        }
    }
}
