using System;
using Modelo.Dados;

namespace Programa
{
    public class Program
    {
        static void Main(string[] args)
        {
            Universidade[] VetorUniversidades = new Universidade[0];

            int op = 0;
            while (op != 5)
            {
                Console.WriteLine("Selecione uma opção:\n");
                Console.WriteLine("1 - Registrar universidade");
                Console.WriteLine("2 - Registrar departamento");
                Console.WriteLine("3 - Exibir lista de universidades e departamentos");
                Console.WriteLine("4 - Registrar professor");
                Console.WriteLine("5 - Finalizar programa");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        string nome;

                        bool ocorrenciaN = false;

                        Console.WriteLine("Insira o nome da Universidade a ser registrado:");
                        nome = Console.ReadLine();
                        for (int i = 0; i < VetorUniversidades.Length; i++)
                        {
                            if (nome == VetorUniversidades[i].GetNome())
                            {
                                ocorrenciaN = true;
                                Console.WriteLine("Já existe uma universidade cadastrada com o nome fornecido\n");
                                break;
                            }
                        }

                        if (ocorrenciaN == false)
                        {
                            Universidade universidade = new Universidade(nome);
                            Array.Resize(ref VetorUniversidades, VetorUniversidades.Length + 1);
                            VetorUniversidades[VetorUniversidades.Length - 1] = universidade;
                        }

                        break;

                    case 2:
                        string sig;
                        Console.WriteLine("Insira o nome da universidade a qual deseja registrar um departamento:");
                        sig = Console.ReadLine();
                        bool find = false;

                        for (int i = 0; i < VetorUniversidades.Length; i++)
                        {
                            if (sig == VetorUniversidades[i].GetNome())
                            {
                                VetorUniversidades[i].addDepartamento();
                                find = true;
                                break;
                            }
                        }

                        if (find == false) Console.WriteLine("Não foi possível encontrar uma universidade com o nome informado.");

                        break;

                    case 3:
                        for (int i = 0; i < VetorUniversidades.Length; i++)
                        {
                            VetorUniversidades[i].MostrarDepartamentos();
                        }
                        break;

                    case 4:
                        var professor = new Professor();
                        professor.SetNome();

                        break;

                    case 5:
                        Console.WriteLine("\nFim!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}