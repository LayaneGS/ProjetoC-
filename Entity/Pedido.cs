namespace ProjetoC_.Entity
{
    public class Pedido
    {

        public int Id { get; set; }
        public DateTime Data_Pedido { get; set; }
        public decimal Total { get; set; }
        public enum Status { Active, Inactive, Pending }
    }
}
