using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApi.Entities.Autor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/autores")]
    [ApiController]
    public class AutorsController : ControllerBase
    {
        private readonly IAutorService _autorService;
        public AutorsController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_autorService.GetAll().ToList());
        }

        [HttpPost]
        public ActionResult Create([FromBody] AutorRequest request)
        {
            if (request == null)
            {
                return null;
            }

            var autor = new Autor()
            {
                Nome = request.Nome,
                Sobrenome = request.Sobrenome,
                Email = request.Email,
                DataNascimento = DateTime.Parse(request.DataNascimento),
                LivroId = request.LivroId,
            };

            var response = _autorService.AddAutor(autor);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _autorService.DeleteAutor(Guid.Parse(id));
            return Ok();
        }

        [HttpPatch("{id}")]
        public ActionResult Update(string id, [FromBody] AutorRequest request)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            _autorService.UpdateAutor(id, request);
            return Ok();
        }
    }
}
