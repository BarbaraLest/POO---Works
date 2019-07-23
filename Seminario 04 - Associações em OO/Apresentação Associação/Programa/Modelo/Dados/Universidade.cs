using System;

namespace Modelo.Dados
{
     public class Universidade
    {
        private string _nome { get; set; }

        private Departamento[] _departamentos = new Departamento[0];
        private Departamento[] Departamentos
        {
            get => _departamentos;
            set => _departamentos = value;
        }

        public Universidade(string nome)
        {
            this._nome = nome;
        }

        public bool DepartamentoRegistrado(string nome)
        {
            bool find = false;
            for (int i = 0; i < Departamentos.Length; i++)
            {
                if (Departamentos[i].GetNome() == nome)
                {
                    find = true;
                    return find;
                }
            }
            return find;
        }

        public override string ToString()
        {
            return this._nome;
        }

        public string GetNome()
        {
            return this._nome;
        }

        public void SetNome()
        {
            Console.WriteLine("Insira o nome da universidade que deseja cadastrar:");
            string nome = Console.ReadLine();
            this._nome = nome;
        }

        public void addDepartamento()
        {
            Departamento departamento= new Departamento(this);
            departamento.SetNome();

            bool ocorrencia = false;
            for (int i = 0; i < this._departamentos.Length; i++)
            {
                if (departamento.Equals(_departamentos[i]))
                {
                    ocorrencia = true;
                }
            }
            if (ocorrencia == false)
            {
                Array.Resize(ref _departamentos, _departamentos.Length + 1);
                this.Departamentos[Departamentos.Length - 1] = departamento;
            }
            else
            {
                Console.WriteLine("O departamento inserido já está registrado.\n");
            }
        }

        public void MostrarDepartamentos()
        {
            Console.WriteLine($"-------{this._nome}-------");
            for (int i = 0; i < Departamentos.Length; i++)
            {
                Console.WriteLine($"-{Departamentos[i]}");
            }
            Console.WriteLine("\n");
        }
    }
}
