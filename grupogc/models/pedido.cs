namespace Models
{
       public class pedido
       {
              //Atributos da nossa classe pedido 
              private int id_pedido { get; set; }
               private string local { get; set; }

              private int data { get; set; }

              private int hora { get; set; }
              private string cliente { get; set; }
              private string produto { get; set; }
              
              public pedido(string localpedido, int datapedido, int horapedido, string clientepedido, string produtopedido)
              {
                     this.local = localpedido;
                     this.data = datapedido;
                     this.hora = horapedido;
                     this.cliente = clientepedido;
                     this.produto = produtopedido;
              }
       }
}

