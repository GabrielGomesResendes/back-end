public class Program
{
    public static void Main()
    {


        //o try serve para tratar um erro e não para execução do programa
        //Se ocorrer qualquer erro dentro do bloco try, o sistema interrope
        // execução do bloco e vai para o catch
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"voce digitou o nº {numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"o resultado é {resultado}");
        }
        //tratando exeção de overflow (estouro e campo)
        catch(OverflowException)
        {
            Console.WriteLine("este numero inteiro é maior que o suportado");
        }
        //tratamento exeção de erro de formato
        catch(FormatException)
        {
            Console.WriteLine($"digite um numero inteiro");
        }

        //Catch é o tratamento do erro, normalmente colocamos as mensagens de acordo 
        //Com o tipo do erro, para melhor compreenção do usuario

        catch (Exception ex)
        {
            Console.WriteLine($"ocorreu um erro: {ex.Message}");
        }
        //O finally é um bloco executado independente se ocorrer erro ou não
        finally
        {
            Console.WriteLine("entrando no finally");
        }
    }
}
