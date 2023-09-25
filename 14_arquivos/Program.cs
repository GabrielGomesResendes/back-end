using System.IO;

public class Program
{

    public static void Main()
    {
        //chamando um metodo gravar arquivo
        GravarArquivo();
        //chamando um metodo lerarquivo
        LerArquivo();
    }

    public static void LerArquivo()
    {
        string CaminhoArquivo = "Arquivo/arquivo.txt";

        try
        {
            //verificar se o arquivo existe
            if (File.Exists(CaminhoArquivo) == false)
            {
            //criando meu arquivo.txt, este comando é executado quando
            //a verificaçao no if é falsa ou seja o arquivo não existe
            File.Create("Arquivo/arquivo.txt");
            }


            //instanciando um objeto da classe streanreader par ler o arquivo 
            using (StreamReader arquivo = new StreamReader("Arquivo/arquivo.txt"))
            {
                string linha;
                //fazendo o while para ler linha por linha que contém no arquivo
                while ((linha = arquivo.ReadLine()) != null)
                {
                    //escrevendo no console o conteudo da linha 
                    Console.WriteLine(linha);
                }
            }
        }

catch (Exception erro)
        {
            Console.WriteLine("ocorreu um erro ao ler o arquivo");
        }
    
        
    }
    public static void GravarArquivo()
    {
        try
        {
            using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", true))
            {
                Console.WriteLine("digite um texto para salvar no arquivo");
                string nome = (Console.ReadLine());
                arquivo.WriteLine($"{nome}");

            }
        }
        catch (Exception erro)
        {
            Console.WriteLine("ocorreu um erro ao ler o arquivo");
        }
    }
}