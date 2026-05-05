using System;

namespace POO_universidade
{
    class Program
    {
        static void Main(string[] args)
        {
            UnidadeCurricular uc = new UnidadeCurricular();
            uc.Nome = "Programação";

            int opcao = -1;

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine(" ********************************* MENU ********************************* ");
                Console.WriteLine("1 - Add Estudante");
                Console.WriteLine("2 - Listar Estudantes");
                Console.WriteLine("3 - Add Avaliação");
                Console.WriteLine("4 - Exibir Pauta");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    int idade = int.Parse(Console.ReadLine());

                    Console.Write("Número da Matrícula: ");
                    int numero = int.Parse(Console.ReadLine());

                    Estudante e = new Estudante();
                    e.Nome = nome;
                    e.Idade = idade;
                    e.NumeroMatricula = numero;

                    uc.Estudantes.Add(e);

                    Console.WriteLine("Estudante adicionado!");
                    Console.ReadKey();
                }

                else if (opcao == 2)
                {
                    Console.WriteLine("Estudantes:");

                    foreach (var e in uc.Estudantes)
                    {
                        Console.WriteLine(e.Nome + " - " + e.NumeroMatricula);
                    }

                    Console.ReadKey();
                }

                else if (opcao == 3)
                {
                    Console.WriteLine("1-Teste  2-Projecto  3-Exame");
                    int tipo = int.Parse(Console.ReadLine());

                    Console.Write("Nota: ");
                    double nota = double.Parse(Console.ReadLine());

                    if (tipo == 1)
                        uc.Avaliacoes.Add(new Teste { Nota = nota});

                    else if (tipo == 2)
                        uc.Avaliacoes.Add(new Projecto { Nota = nota});

                    else if (tipo == 3)
                        uc.Avaliacoes.Add(new ExameFinal { Nota = nota});

                    Console.WriteLine("Avaliação adicionada!");
                    Console.ReadKey();
                }

                else if (opcao == 4)
                {
                    uc.EmitirPauta();
                    Console.ReadKey();
                }
            }
        }
    }
}