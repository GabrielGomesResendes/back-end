// FUNÇAO EM JAVAscript
//function nomefuncao (nome){
    //}

    //funcao / metodo em c#endregion
    // pulblic static string nomefuncao(string nome) {
        //}

        class Sesi
        {
            public static void Main()
            {
                MostrarMensagem("seja bem vindo");
                MostrarMensagem("sesi senai");
                ImprimeDataHora();
                double potencia = Potenciacao(4);
                Console.WriteLine($"potencia {potencia}");
                ContagemRegressiva(10);
            }
  // metodo com parametro e retorno
            public static double Potenciacao(int num){
                double resultado = Math.Pow(num, 2);
                return resultado;
            }
            //Metodo sem parametro e sem retorno
            public static void ImprimeDataHora(){
                Console.WriteLine(DateTime.Now.ToString());
            }
            //Metodo com parametro e sem retorno
            public static void MostrarMensagem(string mensagem)
            {
                Console.WriteLine(mensagem);
            }

            public static void ContagemRegressiva(int n)
            {
                while (n >= 0)
                {
                    Console.WriteLine(n);
                    n--;
                    System.Threading.Thread.Sleep(500);
                }
                Console.WriteLine("bomm");
            }

            public static void JogoQueNrSouEu()
            {
                Console.WriteLine("***************************************");
                 Console.WriteLine("      Bem vindo ao jogo    ");
                  Console.WriteLine("Sorteei um n° de 1 a 20, tente adivinha-lo ");
                   Console.WriteLine("*********************");
                    Console.WriteLine("");

                    random rnd = new random();
                    int nrSorteado = rnd.Next(20);
                    int nrDigitado = -1;

                    do {
                        Console.WriteLine("digite um n°");
                        nrDigitado = int.Parse(Console.ReadLine());
                        if (nrDigitado > nrSorteado)
                        Console.WriteLine("o numero digitado é maoior qu o serteado");
                        else if (nrDigitado < nrSorteado)
                        Console.WriteLine("o numero digitado é menor que o sorteado");
                    } while (nrDigitado != nrSorteado);

                    Console.WriteLine("parabens voce acertou");
            }
        }