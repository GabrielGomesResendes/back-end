class program
{
    public static void Main()
    {
Console.WriteLine("digite o numero:");
        int numero = int.Parse(Console.ReadLine());
        double valor = dobro(numero);
        Console.WriteLine($"dobro {valor}");
        
Console.WriteLine("digite o numero:");
        int valorDigitado = int.Parse(Console.ReadLine());
        int metade = Metade(valorDigitado);

        Console.WriteLine($"Metade {metade}");
        Console.WriteLine("Digite um numero para calcular a tabuada");
        CarregarTabuada(int.Parse(Console.ReadLine()));

    }

    public static double dobro(int num)
    {
        double resultado = num + num;
        return resultado;
    }
    public static int Metade(int num)
    {
        int resultado = (num / 2);
        return resultado;
    }
    
    public static void CarregarTabuada(int n)
    {
        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLin,
            e(contador * n);
            contador++;
        }
    }







}
