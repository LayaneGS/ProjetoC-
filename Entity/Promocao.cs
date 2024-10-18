namespace ProjetoC_.Entity
{
    public class Promocao
    {
        public int Id { get; set; }
        public decimal Desconto { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime Data_Fim { get; set; }
        public int Produto_Id { get; set; }

    }
}
