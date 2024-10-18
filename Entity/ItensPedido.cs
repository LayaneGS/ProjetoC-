using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoC_.Entity
{
    public class ItensPedido
    {
        public int Id { get; set; }

        [ForeignKey("Pedido")]
        public int PedidoId { get; set; }

        //DECLARO A FOREIGN KEY
        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }
        public decimal Preco_Unitario { get; set; }

        public Produto Produto { get; set; }//RECEBO A CONEXÃO LA DA ORIGEM
        public Pedido Pedido { get; set; }




    }
}
