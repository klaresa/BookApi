using BookApi.Entities.Autor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Entities.Autor
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _repository;
        public AutorService(IAutorRepository repository)
        {
            _repository = repository;
        }

        public Autor AddAutor(Autor autor)
        {
           
            if (autor == null)
            {
                throw new Exception("Autor nao definido");
            }


            autor.Id = Guid.NewGuid();

            _repository.Create(autor);

            return autor;
        }

        public void DeleteAutor(Guid id)
        {
            if (id == null)
            {
                throw new Exception("Autor nao definido");
            }

            var autor = _repository.ReadAll().FirstOrDefault(item => item.Id == id);

            _repository.Delete(autor);
        }

        public IEnumerable<Autor> GetAll()
        {
            return _repository.ReadAll();
        }

        public Autor GetAutorById(Guid id)
        {
            return _repository.ReadAll().FirstOrDefault(item => item.Id == id);
        }

        public Autor GetAutorByName(string name)
        {
            return _repository.ReadAll().FirstOrDefault(item => item.Nome.ToLower() == name.ToLower());
        }

        public Autor UpdateAutor(string id, AutorRequest autor)
        {

            if (autor == null)
            {
                throw new Exception("Autor nao pode ser nulo");
            }

            var found = _repository.ReadAll().FirstOrDefault(item => item.Id == Guid.Parse(id));

            found.Id = found.Id;
            found.Nome = autor.Nome;
            found.Sobrenome = autor.Sobrenome;
            found.Email = autor.Email;
            found.DataNascimento = found.DataNascimento;
            found.LivroId = found.LivroId;

            _repository.Update(found);

            return found;
        }
    }
}
 