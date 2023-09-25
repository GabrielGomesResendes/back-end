using Models;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Bem-Vindo a sua conta corrente");
        Console.WriteLine("Aqui seus dados estão em segurança");
        Console.WriteLine("Pode contar conosco sempre");

        Menu();

    }

    public static void Menu()
    {

        Console.WriteLine("digite teu nome");
        ContaCorrente conta1 = new ContaCorrente(Console.ReadLine(), 0);

        string opcao = "";

        do
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$ Opções $$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("1 - para Consultar Saldo");
            Console.WriteLine("2 - para Depositar");
            Console.WriteLine("3 - para Sacar");
            Console.WriteLine("4 - para Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    conta1.ConsultarSaldo();
                    break;
                case "2":
                    conta1.Depositar();
                    break;
                case "3":
                    conta1.Sacar();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
                case "4":
                    Console.WriteLine("Obrigado, volte sempre");
                    System.Threading.Thread.Sleep(1000);
                    break;
            }
        } while (opcao != "4");




    }
}