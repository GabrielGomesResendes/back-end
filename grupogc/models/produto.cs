namespace Models
{
       public class produto
       {
              //Atributos da nossa classe produto 

              private int id_produto { get; set; }

              private string nome { get; set; }

              private string descricao { get; set; }

              private int preco { get; set; }
              private string foto { get; set; }

              public produto(string nomeproduto, string descricaoproduto, int precoproduto, string fotoproduto)
              {
                     this.nome = nomeproduto;
                     this.descricao = descricaoproduto;
                     this.preco = precoproduto;
                     this.foto = fotoproduto;
              }
       }

}