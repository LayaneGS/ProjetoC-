namespace ProjetoC_.Entity
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_Admissao { get; set; }
        public Decimal Salario { get; set; }
        public bool Ativo { get; set; }

    }
}
