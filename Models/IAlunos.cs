using ListaDeAlunos.Models;

namespace digitalinnovationone_aluno_nota_e_media.Models
{
    public interface IAlunos
    {
        void GetAlunos();
        Aluno GetAluno(string nome);
        void GetMedia();
        void AddNotas(double nota, string nome);
    }
}