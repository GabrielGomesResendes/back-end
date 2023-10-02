using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_CRUD_BD.Models
{

    //DataAnnotation de como será criado o nome da tabela no BD
    [Table("jogos")]
    public class jogo
    {
        [Key] //falando para o db que este atributo será uma chave 
        public int JogoId { get; set; }
        [Required(ErrorMessage="Nome É obrigatorio")]
        [MaxLength(200, ErrorMessage="Nome É obrigatorio")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }
    }
}