namespace ProjetoC_.Entity
{
    public class Produto // Criando nova tabela 
    {
        public int Id { get; set; } //get - pegar, set - alterar (ler e alterar)
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public DateTime Data_Adcionado { get; set; }


        public ICollection<ItensPedido> ItensPedido { get; set; } //ABRE A CONEXÃO COM A TABELA DESEJADA

    }
}
