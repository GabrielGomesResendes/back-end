using Models;

public class Program
{
    public static void Main()
    {
        Pessoa pessoa1= new Pessoa("douglas",35, "dougla.camata@gmail.com");   
        pessoa1.Cantar();
        pessoa1.Informacoes(); 
        Pessoa pessoa2= new Pessoa("ricardo",36, "ricardo.camata@gmail.com");   
        pessoa2.Cantar();
        pessoa2.Informacoes(); 
    }
}