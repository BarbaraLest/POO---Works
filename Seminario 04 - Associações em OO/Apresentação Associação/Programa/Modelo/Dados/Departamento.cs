using System;

namespace Modelo.Dados
{
     public class Departamento
    {
        private string _nome { get; set; }
        public Universidade Pertence;
        private Professor[] _professores = new Professor[0];
        private Professor[] Professores
        {
            get => _professores;
            set => _professores = value;
        }

        public bool ProfessorRegistrado(string nome)
        {
            bool find = false;
            for (int i = 0; i < Professores.Length; i++)
            {
                if (Professores[i].GetNome() == nome)
                {
                    find = true;
                    return find;
                }
            }
            return find;
        }

        public void addProfessor()
        {
            Professor professores = new Professor(this);
            professores.SetNome();

            bool ocorrencia = false;
            for (int i = 0; i < this._professores.Length; i++)
            {
                if (professores.Equals(_professores[i]))
                {
                    ocorrencia = true;
                }
            }
            if (ocorrencia == false)
            {
                Array.Resize(ref _professores, _professores.Length + 1);
                this.Professores[Professores.Length - 1] = professores;
            }
            else
            {
                Console.WriteLine("O professor inserido já está registrado.\n");
            }
        }


        public void SetNome()
        {
            Console.WriteLine("Insira o nome do departamento que deseja adicionar:");
            string nome = Console.ReadLine();
            this._nome = nome;
        }

        public string GetNome()
        {
            return this._nome;
        }   

        public Departamento(Universidade universidade)
        {
            this.Pertence = universidade;
        }

        public override string ToString()
        {
            return this._nome;
        }
    }
}
