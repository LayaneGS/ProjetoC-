using Microsoft.EntityFrameworkCore;
using ProjetoC_.Entity;

namespace ProjetoC_.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) 
        { 

        }
        public DbSet<Produto> Produto { get; set; } //Passei para o banco que criei uma NOVA TABELA 
        public DbSet<Funcionario> Funcionario { get; set; } //Passei para o banco que criei uma NOVA TABELA 
        public DbSet<Pedido> Pedido { get; set; } //Passei para o banco que criei uma NOVA TABELA 
        public DbSet<Promocao> Promocao { get; set; } //Passei para o banco que criei uma NOVA TABELA 
        public DbSet<Usuario> Usuario { get; set; } //Passei para o banco que criei uma NOVA TABELA 


    }
}
