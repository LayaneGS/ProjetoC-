namespace ProjetoC_.Entity
{
    public class Produto // Criando nova tabela 
    {
        public int Id { get; set; } //get - pegar, set - alterar (ler e alterar)
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public bool Situacao { get; set; }
    }
}
