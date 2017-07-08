using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Livraria.Repositories;

namespace Livraria.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170708202020_Add-Estoque-Livros")]
    partial class AddEstoqueLivros
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Livraria.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ano");

                    b.Property<string>("Autor")
                        .IsRequired();

                    b.Property<int>("Edicao");

                    b.Property<string>("Editora")
                        .IsRequired();

                    b.Property<int>("Estoque");

                    b.Property<string>("ISBN")
                        .IsRequired();

                    b.Property<int>("Paginas");

                    b.Property<string>("Titulo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Livros");
                });
        }
    }
}
