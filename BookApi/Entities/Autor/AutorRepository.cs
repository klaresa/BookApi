using BookApi.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Entities.Autor
{
    public class AutorRepository : IAutorRepository
    {
        public readonly BookApiContext _context;
        public AutorRepository(BookApiContext context)
        {
            _context = context;
        }


        public void Create(Autor autor)
        {
            _context.Autores.Add(autor);
            _context.SaveChanges();
        }

        public void Delete(Autor autor)
        {
            _context.Autores.Remove(autor);
            _context.SaveChanges();
        }

        public IEnumerable<Autor> ReadAll()
        {
            return _context.Autores;
        }

        public void Update(Autor autor)
        {
            _context.Autores.Update(autor);
            _context.SaveChanges();
        }
    }
}
