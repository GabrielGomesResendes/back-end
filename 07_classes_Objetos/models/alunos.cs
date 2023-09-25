//o namespace é um nome que usaremos para fazer referencia quando usarmos em
//outras classes


namespace Sesi.Model
{
    //Declarando nosso atributos (propiedade) da classe
    public class Aluno
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }

        public int nrFaltas { get; set; }

       //Criando um método

       public void Apresentar()
       {
        Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade}, anos e estudo na turma {turma}!!!");
       }

       public void AdicionarFaltas(int nr)
       {
        nrFaltas = nrFaltas + nr;
       }

       public void ResumirFaltas()
       {
        Console.WriteLine($"{nome} voce tem {nrFaltas}faltas");
       }

          public void JustificarFaltas(int nr)
       {
        nrFaltas = nrFaltas - nr;
       }
    }
}