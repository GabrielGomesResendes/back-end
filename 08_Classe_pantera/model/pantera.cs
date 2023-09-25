namespace Models
{
    public class Pantera
    {
        public decimal tamanho { get; set; }

        public int peso { get; set; }

        public string cor { get; set; }

        public string especie { get; set; }

        public string alimetacao { get; set; }


        public void Correr(){
            Console.WriteLine("A Pantera esta correndo");
        }
        public void Cacar(){
            Console.WriteLine("A Pantera esta caçando");
        }
        public void Reproduzir(){
            Console.WriteLine("A Pantera esta reproduzindo");
        }


    }
}