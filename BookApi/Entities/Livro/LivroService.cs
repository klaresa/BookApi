using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApi.Entities.Livro;

namespace BookApi.Entities.Livro
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _repository;
        public LivroService(ILivroRepository repository)
        {
            _repository = repository;
        }

        public Livro AddLivro(Livro livro)
        {

            // é aqui que o autor deve ser adicionado

            if (livro == null)
            {
                throw new Exception("Livro nao definido");
            }

            if (livro.AutorId == null)
            {
                throw new Exception("Nao se pode cadastrar um livro sem autor");
            }


            livro.Id = Guid.NewGuid();
            livro.AutorId = livro.AutorId;
            

            _repository.Create(livro);

            return livro;
        }

        public Livro UpdateLivro(string id, LivroRequest livro)
        {

            if (livro == null)
            {
                throw new Exception("Livro nao pode ser nulo");
            }

            var found = _repository.ReadAll().FirstOrDefault(item => item.Id == Guid.Parse(id));

            found.Id = found.Id;
            found.Titulo = livro.Titulo;
            found.Isbn = livro.Isbn;
            found.Ano = livro.Ano;

            found.AutorId = found.AutorId;

            _repository.Update(found);

            return found;
        }

        public void DeleteLivro(Guid id)
        {
            if (id == null)
            {
                throw new Exception("Livro nao definido");
            }

            var livro = _repository.ReadAll().FirstOrDefault(item => item.Id == id);

            _repository.Delete(livro);
        }

        public IEnumerable<Livro> GetAll()
        {
            return _repository.ReadAll();
        }

        public Livro GetLivroById(Guid id)
        {
            return _repository.ReadAll().FirstOrDefault(item => item.Id == id);
        }

        public Livro GetLivroByName(string titulo)
        {
            return _repository.ReadAll().FirstOrDefault(item => item.Titulo.ToLower() == titulo.ToLower());
        }

    }
}
