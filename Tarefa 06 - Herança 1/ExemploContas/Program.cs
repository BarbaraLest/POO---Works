using ExemploContas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploContas
{
    class Program
    {
        static void Main(string[] args)
        {
            //testes conta simples
            var contasimples = new ContaSimples();
            contasimples.Correntista = "Barbara";
            contasimples.Num = 01;
            contasimples.Creditar(50);
           //contasimples.Debitar(50);

            Console.WriteLine(contasimples.Correntista);
            Console.WriteLine(contasimples.Num);
            Console.WriteLine(contasimples.SaldoDisponivel);

            //testes conta especial
            var contaespecial = new ContaEspecial()
            {

            };
            contaespecial.Correntista = "Ana";
            contaespecial.Num = 02;
            contaespecial.Limite = 20;
            contaespecial.Creditar(100);
            

            Console.WriteLine(contaespecial.Correntista);
            Console.WriteLine(contaespecial.Num);
            Console.WriteLine(contaespecial.SaldoDisponivel);

            //testes conta investimento
            var containv = new ContaInvestimento();
            containv.Correntista = "Marcos";
            containv.Num = 03;
            containv.Creditar(20);
            containv.Investimento = 200;

            Console.WriteLine(containv.Correntista);
            Console.WriteLine(containv.Num);
            //saldo creditado + rendimento do saldo investido.
            Console.WriteLine(containv.SaldoDisponivel);



            Console.ReadKey();
        }
    }
}
