using BookApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Entities.Autor
{
    public interface IAutorService
    {
        public Autor AddAutor(Autor autor);
        public Autor UpdateAutor(string id, AutorRequest request);
        public IEnumerable<Autor> GetAll();
        public Autor GetAutorByName(string name);
        public Autor GetAutorById(Guid id);
        public void DeleteAutor(Guid id);
    }
}
