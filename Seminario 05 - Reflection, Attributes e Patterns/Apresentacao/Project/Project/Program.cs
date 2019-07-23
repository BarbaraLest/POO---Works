using System;
using Modelo.Dados;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var colaborador = new Colaborador()
            {
                Nome = "Lucas",
                Funcao = "Desenvolvedor C#",
                Salario = 6000
            };

            var chefe = new Chefe()
            {
                Nome = "Fernando",
                Setor = "Desenvolvimento de projetos",
                Salario = 12000
            };

            Logando(colaborador, chefe);

            Console.ReadKey();
        }
       
        public static void Logando(Colaborador col, Chefe boss)
        {
            Reflection.Log(col);
            Reflection.Log(boss);
        }
    }
}
