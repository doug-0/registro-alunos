using backend.Model;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
  public class StudentsContext : DbContext
  {
    public StudentsContext(DbContextOptions<StudentsContext> options) : base(options)
    {
    }

    public DbSet<Students> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Students>().ToTable("tb_estudantes");
      modelBuilder.Entity<Students>().HasKey(i => i.Id);
      modelBuilder.Entity<Students>().Property(i => i.Id).HasColumnName("id").ValueGeneratedOnAdd();
    }
  }
}