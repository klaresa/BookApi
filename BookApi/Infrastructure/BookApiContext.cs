using BookApi.Entities.Livro;
using BookApi.Entities.Autor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Infrastructure
{
    public class BookApiContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }

        public BookApiContext(DbContextOptions<BookApiContext> options): base(options)
        {
                
        }

        public class AppContextFactory : IDesignTimeDbContextFactory<BookApiContext>
        {
            public BookApiContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<BookApiContext>();
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookApiDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                return new BookApiContext(optionsBuilder.Options);
            }

        }
    }
}
