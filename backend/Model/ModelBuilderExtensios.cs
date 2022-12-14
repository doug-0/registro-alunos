using Microsoft.EntityFrameworkCore;

namespace backend.Model
{
  public static class ModelBuilderExtensios
  {
    public static void Seed(this ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Students>().HasData(
        new Students
        {
          Id = 1,
          RA = 321,
          Name = "Douglas Oliveira",
          Email = "douglas@email.com",
          CPF = "999.888.777-66",
        },
        new Students
        {
          Id = 2,
          RA = 535,
          Name = "Paula Souza",
          Email = "Paula@email.com",
          CPF = "555.333.222-11",
        },
        new Students
        {
          Id = 3,
          RA = 987,
          Name = "João Silva",
          Email = "jao@email.com",
          CPF = "111.222.444-55",
        },
        new Students
        {
          Id = 4,
          RA = 746,
          Name = "Marina Miranda",
          Email = "mari@email.com",
          CPF = "333.222.888-66",
        },
        new Students
        {
          Id = 5,
          RA = 125,
          Name = "Maurício Souza",
          Email = "souza@email.com",
          CPF = "444.333.009-88",
        }
      );
    }
  }
}