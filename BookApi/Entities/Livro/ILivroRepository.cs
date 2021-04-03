using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Entities.Livro
{
    public interface ILivroRepository
    {
        public void Create(Livro livro);
        public IEnumerable<Livro> ReadAll();
        public void Update(Livro livro);
        public void Delete(Livro livro);
    }
}
