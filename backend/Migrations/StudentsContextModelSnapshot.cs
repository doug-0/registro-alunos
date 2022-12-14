// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(StudentsContext))]
    partial class StudentsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("backend.Model.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("RA")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("tb_estudantes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPF = "999.888.777-66",
                            Email = "douglas@email.com",
                            Name = "Douglas Oliveira",
                            RA = 321
                        },
                        new
                        {
                            Id = 2,
                            CPF = "555.333.222-11",
                            Email = "Paula@email.com",
                            Name = "Paula Souza",
                            RA = 535
                        },
                        new
                        {
                            Id = 3,
                            CPF = "111.222.444-55",
                            Email = "jao@email.com",
                            Name = "João Silva",
                            RA = 987
                        },
                        new
                        {
                            Id = 4,
                            CPF = "333.222.888-66",
                            Email = "mari@email.com",
                            Name = "Marina Miranda",
                            RA = 746
                        },
                        new
                        {
                            Id = 5,
                            CPF = "444.333.009-88",
                            Email = "souza@email.com",
                            Name = "Maurício Souza",
                            RA = 125
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
