using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApi.Entities.Livro;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/livros")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroService _livroService;
        public LivrosController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_livroService.GetAll().ToList());
        }

        [HttpPost]
        public ActionResult Create([FromBody] LivroRequest request)
        {
            if (request == null)
            {
                return null;
            }

            var livro = new Livro()
            {
                Titulo = request.Titulo,
                Isbn = request.Isbn,
                Ano = request.Ano,

                AutorId = request.AutorId,
            };

            var response = _livroService.AddLivro(livro);

            return Ok(response);
        }
    
        [HttpPatch("{id}")]
        public ActionResult Update(string id, [FromBody] LivroRequest request)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            _livroService.UpdateLivro(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _livroService.DeleteLivro(Guid.Parse(id));
            return Ok();
        }
    }
}
