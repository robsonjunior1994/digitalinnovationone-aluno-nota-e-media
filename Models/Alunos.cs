using System;
using System.Collections.Generic;

namespace ListaDeAlunos.Models
{
    public class Alunos
    {
        public List<Aluno> Lista {get; set;}
        public Double MediaGeral {get; private set;}

        public Alunos() {
            Lista = new List<Aluno>();
        }

        public void ListarAlunosESuasMedias(){
            throw new Exception();
        }
        public void GetAlunos()
        {
            foreach (var a in Lista)
            {
                    Console.WriteLine($"Nome: {a.Nome}, Nota: {a.Nota}");
            }
        }

        public void GetMedia(){
            double total = 0;

            foreach (var a in Lista)
            {
                total += a.Nota;
                MediaGeral = total/ Lista.Count;  
            }

             Console.WriteLine($"Total é: {total}");

        }
    }

}