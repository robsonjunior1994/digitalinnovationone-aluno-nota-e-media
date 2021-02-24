/*

Criar aluno, ao criar informe nome, nota
Criar um conjunto de alunos
Listar os alunos e suas notas
media geral de todos os alunos

*/

using System;
using System.Collections.Generic;
using ListaDeAlunos.Models;

namespace ListaDeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Robson", 9);
            Aluno a2 = new Aluno("Joyce", 10);
            Aluno a3 = new Aluno("Tuti", 5);

            a1.AdicionarNota(8);
            a2.AdicionarNota(7);
            a3.AdicionarNota(10);

            Alunos Alunos = new Alunos();
            Alunos.Lista.Add(a1);
            Alunos.Lista.Add(a2);
            Alunos.Lista.Add(a3);

            Console.Write("*-------------------------------*");
            Alunos.ListarInormacoes();

            Console.WriteLine("\n\n*-------------------------------*");
            Alunos.ListarAlunosESuasMedias();

            Console.WriteLine("\n*-------------------------------*");
            Alunos.GetMediaDeTodosOsAlunos();

        }
    }
}
