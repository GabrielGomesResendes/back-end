public class Program
{
    public static void Main()
    {
          var pessoa1 = new {
            nome = "jao",
            idade = 17
        };
        var pessoa2 = new {
            nome = "maria",
            email = "maria@aluno.senai.org"
        };
      

        Console.WriteLine($"a pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos ");
    
        Console.WriteLine($"a pessoa2 é {pessoa2.nome} e tem o email {pessoa2.email}");


        var carro1 = new {
            marca = "vw",
            modelo = "gol",
            ano = "2020",
        }
    }
}
