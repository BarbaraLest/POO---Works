using System;

namespace Modelo.Dados
{
    public class Professor
    {
        private string _nome { get; set; }
        public Departamento Pertence;

        public void SetNome()
        {
            Console.WriteLine("Insira o nome do professor que deseja adicionar:");
            string nome = Console.ReadLine();
            this._nome = nome;
        }

        public string GetNome()
        {
            return this._nome;
        }

        public Professor(Departamento departamento)
        {
            this.Pertence = departamento;
        }

        public Professor()
        {
        }

        public override string ToString()
        {
            return this._nome;
        }
    }
}
