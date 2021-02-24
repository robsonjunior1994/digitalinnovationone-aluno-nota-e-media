using System.Collections.Generic;

namespace ListaDeAlunos.Models
{
    public class Aluno
    {
        public string Nome {get;  set;}
        public double Nota {get; set;}
        public double Media {get; private set;}  
    }
}