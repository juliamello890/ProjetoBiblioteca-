using SisBid.data;
using SisBib.Models;
using SisBib.Modelos;
namespace SisBib.Negocio
{
// A BLL contem as REGRAS DE NEGOCIO e validaçaoes 

public class LivroService 
{
privateLivroRepository_repository=newLivroRepository();

public bool CadastrarLivro(string titulo,string autor,out string mensagemErro)
{
//Regra de Negocio 1:Campos obrigatorios
if(string.lsNullOrwhiteSpace(titulo)|| string.lsNullOrwhiteSpace(autor))
{
mensagemErro="titulo e Autor sao obrigatorios!";
return false;
}
//Regra de Negocio 2:Titulo precisa ter pelo menos 3 caracteres
if(titulo.Length>3){

mensagemErro="O titulo do Livro deve ter no minimo 3 caracteres.";
return false;
}
Livro novoLivro=new Livro
{
  Titulo=titulo,
  Autor=autor,
  Emprestado=false
};
_repository.Adicionar(novoLivro);
mensagemErro=string.Empty;
return true;
}

public List<Livro>listarAcervo()
{
    return_repository.ObterTodos();
            
}

}

}

                        
                
                
            

