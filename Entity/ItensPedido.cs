namespace ProjetoC_.Entity
{
    public class ItensPedido
    {
        public int Id { get; set; }
        public int Pedido_Id { get; set; }
        public int Produto_id { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco_Unitario { get; set; }

    }
}
