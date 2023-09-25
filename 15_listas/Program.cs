using System.Collections.Generic;
using Sesi.Model;
public class Program
{
    public static void Main()
    {
        //criando uma lita de inteiros 
        List<int> listaNumeros = new List<int>();
        //adicionando elementos à lista 
        listaNumeros.Add(10);//posição [0]
        listaNumeros.Add(20);//posição [1]
        listaNumeros.Add(45);//posição [2]

        //acessando os dados da lista pelo indice
        Console.WriteLine(listaNumeros[2]);

        //contagen de elementos
        Console.WriteLine($"Neste Momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(55);//posição [3]

         Console.WriteLine($"Neste Momento temos {listaNumeros.Count} elementos");

        ////////////////////////////////////////////////////////////
        






         List<string> listaNomes = new List<string>();
        //adicionando elementos à lista 
        listaNomes.Add("Gabriel");//posição [0]
        listaNomes.Add("Cauan");//posição [1]
        listaNomes.Add("Vitor");//posição [2]

        //acessando os dados da lista pelo indice
        Console.WriteLine(listaNomes[2]);

        foreach(string nome in listaNomes)
    {
        Console.WriteLine(nome);
    }


        //contagen de elementos
        Console.WriteLine($"Neste Momento temos {listaNomes.Count} nomes");
        
    //criando uma lista de numeros já atribuido valores
    List<int> numeros = new List<int>{1, 2, 5, 6, 8, 9};
    Console.WriteLine($"quantidade de elemento na lista números {numeros.Count}");
    numeros.Remove(5);//remover elemento 5
    numeros.RemoveAt(1);//remover o elemento no indice 1
    numeros.RemoveRange(2,2);//remover 2 elementos apartir do indice 2

    //substituindo informação do item da lista
    numeros[0] = 100;

    //interando sobre todos os items da lista 
    foreach(int item in numeros)
    {
        Console.WriteLine(item);
    }

    //criando uma lista com objetos da classe aluno

    List<Aluno> listaAlunos = new List<Aluno>();

    //adicionando um novo aluno a minha lista 
    Aluno novoAluno = new Aluno("pedro",16);
    listaAlunos.Add(novoAluno);

    listaAlunos.Add(new Aluno("patricia",17));
    listaAlunos.Add(new Aluno("bob",17));

    //exibindo lista de alunos 
    Console.WriteLine("lista de alunos:");
    foreach(Aluno item in listaAlunos)
    {
       Console.WriteLine($"nome do aluno: {item.nome} tem {item.idade}anos"); 
    }
     
     //criando uma nova lista, ordenando por nome 
     //linq utilizando sintaxe de consulta
    var ordenacao = from aluno in listaAlunos
            where aluno.idade ==17
            orderby aluno.nome
            orderby aluno.nome
            select aluno.nome;

    foreach (var aluno in ordenacao)
    {
        Console.WriteLine(aluno);
    }

 //linq utilizando sintaxe de metodo
    var consulta = listaAlunos
                    .Where(aluno => aluno.idade == 17)
                    .OrderBy(aluno => aluno.nome);
    foreach (var aluno in consulta)
    {
        Console.WriteLine(aluno.nome);
    }

 }
}