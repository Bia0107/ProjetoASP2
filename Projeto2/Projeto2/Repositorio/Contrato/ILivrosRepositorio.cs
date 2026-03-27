using Projeto2.Models;

namespace Projeto2.Repositorio.Contrato
{
    public interface ILivrosRepositorio
    {
        IEnumerable<Livro> ObterTodosLivros();
        void Cadastrar(Livro livro);
        void Atualizar(Livro livro);
        Livro ObterLivros(int Id);
        void Excluir(int Id);
    }
}
