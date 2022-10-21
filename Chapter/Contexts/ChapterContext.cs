using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {
        }

        //Método de configuração de banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DANIEL\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }

        //O dbset representa as entidades utilizadas nas operações de leitura, criação, atualização e exclusão.
        public DbSet<Livro> Livros { get; set; }

    }
}
