namespace GerenciadorDeLivraria;

public class Livro {
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public Genero Genero { get; set; } = Genero.Ficcao;
    public double Preco { get; set; }

    public int Quantidade { get; set; }

    public string GetGenero()
    {
        return Genero switch
        {
            Genero.Ficcao => "Ficção",
            Genero.Romance => "Romance",
            Genero.Misterio => "Mistério",
            _ => "Desconhecido",
        };
    }

}

public enum Genero
{
    Ficcao,
    Romance,
    Misterio,
}