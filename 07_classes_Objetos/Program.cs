using Sesi.Model;

class Program
{
    public static void Main()
    {
        var aluno1 = new Aluno();
        aluno1.nome = "GABRIEL";
        aluno1.idade = 16;
        aluno1.turma = "2em";
        

        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas();
    }
}
