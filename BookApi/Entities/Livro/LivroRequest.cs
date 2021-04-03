using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Entities.Livro
{
    public class LivroRequest
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public string Ano { get; set; }

        public Guid AutorId { get; set; }
    }
}
