using BookApi.Entities.Autor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Entities.Autor
{
    public interface IAutorRepository
    {
        public void Create(Autor autor);
        public IEnumerable<Autor> ReadAll();
        public void Update(Autor autor);
        public void Delete(Autor autor);
    }
}
