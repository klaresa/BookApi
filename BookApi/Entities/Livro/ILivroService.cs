using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Entities.Livro
{
    public interface ILivroService
    {
        public Livro AddLivro(Livro livro);
        public Livro UpdateLivro(string id, LivroRequest livro);
        public IEnumerable<Livro> GetAll();
        public Livro GetLivroByName(string name);
        public Livro GetLivroById(Guid id);
        public void DeleteLivro(Guid id);
    }
}
