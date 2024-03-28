namespace GerenciadorDeLivraria.Communication.Requests;

public class RequestUpdateLivroJson
{
    public string? Titulo { get; set; }
    public string? Autor { get; set; }
    public string? Genero { get; set; }
    public double? Preco { get; set; }
    public int? Quantidade { get; set; }
}
