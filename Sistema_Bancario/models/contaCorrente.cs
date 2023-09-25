namespace Models
{

    public class ContaCorrente
    {
        //Atributos da nossa classe Titular 

        private string nome { get; set; }
        private double saldo { get; set; }


        public ContaCorrente(string nomeContaCorrente, int saldoContaCorrente)
        {
            this.nome = nomeContaCorrente;
            this.saldo = saldoContaCorrente;
        }


        //metodo da classe ContaCorrente
        public void ConsultarSaldo()
        {
            Console.WriteLine($" seu saldo é de {saldo}  ");
        }

        public void Depositar()
        {
            Console.WriteLine($"digite o valor a ser depositado");
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0)
            {
                saldo = valor + saldo;
                Console.WriteLine($"Valor depositado!!!");
            }


        }
        public void Sacar()
        {
            Console.WriteLine($"digite o valor a ser sacado");
            double valor = double.Parse(Console.ReadLine());
            if (saldo > valor)
            {
                saldo = saldo - valor;
                Console.WriteLine($"Valor sacado!!!");

            }
        }
    }
    }