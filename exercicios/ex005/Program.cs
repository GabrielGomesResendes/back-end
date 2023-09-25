class Program{
    public static void Main()
    {
       ListaDoChurrasco(); 
    }

    public static void ListaDoChurrasco()
    {
        string[] lista = new string[6];
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("Digite o produto que vamos comprar");
            string produto = Console.ReadLine();
            lista[i] = produto;
        }
        Array.Sort(lista);
        foreach (string item in lista){
            Console.WriteLine(item);
        }
    }
    
}
