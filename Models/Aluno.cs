using System.Collections.Generic;

namespace ListaDeAlunos.Models
{
    public class Aluno
    {
        public string Nome {get;  set;}
        public List<double> Notas {get; set;}

        public Aluno(){
            Notas = new List<double>();
        }
    }
}