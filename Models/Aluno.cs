using System.Collections.Generic;

namespace ListaDeAlunos.Models
{
    public class Aluno
    {
        public string Nome {get; private set;}
        public List<double> Notas {get; private set;}
        public double Media {get; private set;}
        public Aluno(string nome, double nota){
            this.Nome = nome;
            this.Notas = new List<double>();
            this.Notas.Add(nota);
        }

        public void AdicionarNota(double nota){
            this.Notas.Add(nota);
        }

        public void SetMediaAluno()
        {
            double total = 0;

            foreach (var nota in Notas)
            {
                total = total + nota;
            }

            Media = total / Notas.Count;
        }


    }
}