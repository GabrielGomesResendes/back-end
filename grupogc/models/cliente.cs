namespace Models
{

    public class cliente
    {
        //Atributos da nossa classe cliente 
        private int id_cliente { get; set; }

        private string nome { get; set; }

        private int cpf { get; set; }

        private string cep { get; set; }
        private string numeroresidencia { get; set; }
        private string email { get; set; }
        private string contato { get; set; }
        private int senha { get; set; }

        public cliente(string nomecliente, int cpfcliente, int cepcliente, int numeroresidenciacliente, string emailcliente, string contatocliente, int senhacliente)
        {
            this.nome = nomecliente;
            this.cpf = cpfcliente;
            this.cep = cepcliente;
            this.numeroresidencia = numeroresidenciacliente;
            this.email = emailcliente;
            this.contato = contatocliente;
            this.senha = senhacliente;
        }
    }





}
