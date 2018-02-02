using Microsoft.EntityFrameworkCore;
using Propaganda.Models;

namespace Propaganda.Dados
{
    public class PropContexto:DbContext
    {
        public PropContexto(DbContextOptions<PropContexto> options) : base(options) { }
        public DbSet<Areas> Areas { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Turmas> Turmas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Areas>().ToTable("Areas");
            modelBuilder.Entity<Cursos>().ToTable("Cursos");
            modelBuilder.Entity<Turmas>().ToTable("Turmas");

        }
    }
}