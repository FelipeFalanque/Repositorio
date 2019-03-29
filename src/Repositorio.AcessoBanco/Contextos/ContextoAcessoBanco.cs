using Microsoft.EntityFrameworkCore;
using Repositorio.AcessoBanco.Entidades;

namespace Repositorio.AcessoBanco.Contextos
{
    public class ContextoAcessoBanco : DbContext
    {
        public ContextoAcessoBanco(DbContextOptions<ContextoAcessoBanco> options) : base(options)
        { }

        public DbSet<Jogador> Jogadores { get; set; }

        //fluente API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Aluno
            builder.Entity<Jogador>().ToTable("Jogadores");
            builder.Entity<Jogador>().HasKey(x => x.JogadorId);
            builder.Entity<Jogador>().Property(x => x.Nome).HasMaxLength(255).IsRequired(true);
        }
    }
}
