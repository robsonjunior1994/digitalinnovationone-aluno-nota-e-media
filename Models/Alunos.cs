using System;
using System.Collections.Generic;

namespace ListaDeAlunos.Models
{
    public class Alunos
    {
        public List<Aluno> Lista {get; set;}
        private Double MediaGeral {get; set;}

        public Alunos() {
            Lista = new List<Aluno>();
        }

        public void ListarAlunosESuasMedias(){
            foreach (var aluno in Lista)
            {
                aluno.SetMediaAluno();
                Console.WriteLine($"Aluno: {aluno.Nome}, Média: {aluno.Media}");
            }
        }
        public void ListarInormacoes()
        {

                foreach (var a in this.Lista)
                {
                    Console.Write($"\n Nome: {a.Nome}, ");
                    foreach (var n in a.Notas)
                    {
                        Console.Write($" Nota: {n}");
                    }
                }
        }

        public void GetMediaDeTodosOsAlunos(){
            Double total = 0;

            foreach(var a in Lista){
                a.SetMediaAluno();
                total += a.Media;
                MediaGeral = total/Lista.Count;
            }

            Console.WriteLine($"Média de todos os alunos: {MediaGeral}");

        }
    }

}