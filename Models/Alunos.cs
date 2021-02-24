using System;
using System.Collections.Generic;
using digitalinnovationone_aluno_nota_e_media.Models;

namespace ListaDeAlunos.Models
{
    public class Alunos : IAlunos
    {
        public List<Aluno> Lista {get; set;}
        public Double MediaGeral {get; private set;}

        public Alunos() {
            Lista = new List<Aluno>();
        }
        public void GetAlunos()
        {
            foreach (var a in Lista)
            {
                    Console.WriteLine($"Nome: {a.Nome}, Nota: {a.Notas}");
            }
        }
        public Aluno GetAluno(string nome){
            var aluno = Lista.Find(a => a.Nome == nome);
            return aluno;
        }

        
        public void GetMedia(){
            double total = 0;

            foreach (var a in Lista)
            {
                foreach (var n in a.Notas)
                {
                    total += n;
                }                
                MediaGeral = total/ Lista.Count;  
            }

             Console.WriteLine($"Total é: {total}");

        }
        public void AddNotas(double nota, string nome)
        {
            Lista.Find(a2 => a2.Nome == nome).Notas.Add(nota);
        }
    }

}