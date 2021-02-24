using System;
using System.Collections.Generic;
using ListaDeAlunos.Models;

namespace ListaDeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao notas aluno: \n");
            string opcaoUsuario = ObterOpcaoUsuario();
            Alunos alunos = new Alunos();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                    Console.WriteLine("Informe o nome do aluno:");
                    Aluno aluno = new Aluno();
                    aluno.Nome = Console.ReadLine();
                    
                    Console.WriteLine("Informe a nota do aluno:");
                    aluno.Notas.Add(double.Parse(Console.ReadLine()));

                    alunos.Lista.Add(aluno);
                    break;

                    case "2":
                    Console.WriteLine("Lista de alunos:");
                    alunos.GetAlunos();
                    break;

                    case "3":
                    alunos.GetMedia();
                    Console.WriteLine($"Média dos alunos: {alunos.MediaGeral}");

                    break;

                    case "4":
                    Console.WriteLine("Digite o nome do aluno que você deseja encontrar");
                    string nome = Console.ReadLine();
                    var a = alunos.GetAluno(nome);

                    if(a != null){
                        Console.WriteLine($"O aluno {a.Nome} encontrado");
                        Console.WriteLine("Digite mais uma nota para esse aluno");
                        alunos.AddNotas(Double.Parse(Console.ReadLine()), a.Nome);
                    }

                    else{
                         Console.WriteLine($"Aluno {nome}, não foi encontrado!");
                    }

                    break;

                    case "x":
                    Console.WriteLine("Sair");
                    break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                 
                opcaoUsuario = ObterOpcaoUsuario();
            } 
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("4- Encontrar um aluno e adicionar nota");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
