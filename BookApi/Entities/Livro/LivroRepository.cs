using BookApi.Entities.Livro;
using BookApi.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Entities.Livro
{
    public class LivroRepository : ILivroRepository
    {
        private readonly BookApiContext _context;
        public LivroRepository(BookApiContext context)
        {
            _context = context;
        }

        public void Create(Livro livro)
        {
            _context.Add(livro);
            _context.SaveChangesAsync();
        }

        public void Delete(Livro livro)
        {
            _context.Remove(livro);
            _context.SaveChangesAsync();
        }

        public IEnumerable<Livro> ReadAll()
        {
            return _context.Livros;
        }

        public void Update(Livro livro)
        {
            _context.Update(livro);
            _context.SaveChangesAsync();
        }
    }
}
