
using GerenciadorDeLivraria.Communication.Requests;
using GerenciadorDeLivraria.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeLivraria.Controllers;

public class LivroController : GerenciadorDeLivrariaBaseController
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterLivroJson), StatusCodes.Status201Created)]
    public IActionResult RegisterLivro([FromBody] RequestRegisterLivroJson request)
    {
        var response = new ResponseRegisterLivroJson
        {
            Id = 1,
            Titulo = request.Titulo
        };

        return Created("", response);
    }

    [HttpGet("all")]
    [ProducesResponseType(typeof(List<Livro>), StatusCodes.Status200OK)]
    public IActionResult GetAllLivros()
    {
        var response = new List<Livro>()
        {
            new Livro
            {
                Id = 1,
                Titulo = "O Senhor dos Anéis",
                Autor = "J.R.R. Tolkien",
                Genero = Genero.Ficcao,
                Preco = 50.00,
                Quantidade = 10
            },
            new Livro
            {
                Id = 2,
                Titulo = "O Código Da Vinci",
                Autor = "Dan Brown",
                Genero = Genero.Misterio,
                Preco = 40.00,
                Quantidade = 5
            }
        };
        

        return Created("", response);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateLivro([FromRoute] int id, [FromBody] RequestUpdateLivroJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteLivro([FromRoute] int id)
    {
        return NoContent();
    }
}
