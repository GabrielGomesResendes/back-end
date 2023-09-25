namespace Models
{
    public class categoria
    {
        //Atributos da nossa classe categoria 
        private int id_categoria { get; set; }
        private string nomedacategoria { get; set; }
        public categoria(string nomedacategoria)
        {
            this.nomedacategoria = nomedacategoria;
        }
    }


}