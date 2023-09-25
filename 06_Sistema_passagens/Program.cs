class Program
{
   public static string[] poltronas = new string[43];
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem-Vindo ao ResendesBus");
        Console.WriteLine("No ResendesBus você e sua familha estaram segura");
        Console.WriteLine("Contamos com 42 lugares disponiveis");

        Menu();
    }

    public static void Menu()
    {
        string opcao = "";

        do {
               Console.WriteLine("############ Menu ############");
               Console.WriteLine("1 - para comprar passagem");
               Console.WriteLine("2 - para poltronas disponiveis");
               Console.WriteLine("0 - para fechar o sistema");
               opcao = Console.ReadLine();
               Console.Clear();
                 
                 switch (opcao) {
                    case "0":
                         Console.WriteLine("Obrigado, volte sempre");
                         System.Threading.Thread.Sleep(1000);
                         break;
                         case "1":
                            ComprarPassagem();
                         break; 
                        case "2":
                            PoltronasDisponiveis();
                        break;
                        default:
                             Console.WriteLine("Opção invalida");
                             break;
                 }

        } while (opcao != "0");
    }
    public static void ComprarPassagem()
    {
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagens = int.Parse(Console.ReadLine());    

        for (int i = 1; i <= nrPassagens; i++)
        {
            Console.WriteLine($"digite a poltrona da {i}ª passagem");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro:");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome){
        poltronas[nrPoltrona] = nome; 
    }

        public static void PoltronasDisponiveis()
        {
            Console.WriteLine("Lista de poltronas disponiveis");
            for (int i = 1; i<= 42; i++){
                if (poltronas[i] == null){
                    Console.WriteLine($"nº {i}");
                }
            }
        }
}
