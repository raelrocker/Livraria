using Livraria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            :base(options)
        { }

        protected override void OnModelCreating(ModelBuilder buider)
        {
            buider.ForSqlServerUseIdentityColumns();
        }

        DbSet<Livro> Livros { get; set; }
    }
}
