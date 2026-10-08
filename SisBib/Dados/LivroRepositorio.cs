using System.Collections.Generic;
using SisBib.Modelos;
namespace SisBib.#pragma warning disable format

#pragma warning restore format
//A DAL APENAS armazena e recupera dados. nao faz validaçaoes nem imprime texto.

publoic class LivroRepository
{
    private static List<Livro>_tabelaLivros=new List<Livro>();
    private static int proximold= 1;
    public void Adicionar(Livro livro)
{
    livro.ld=proximold++;

    _tabelaLivros.Add(livro);
}
public List<Livro>ObterTodos()
{
    return_tabelaLivros;
}

}

}

