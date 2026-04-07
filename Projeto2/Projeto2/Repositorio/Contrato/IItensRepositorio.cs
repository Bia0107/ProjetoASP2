using Projeto2.Models;

namespace Projeto2.Repositorio.Contrato
{
    public interface IItensRepositorio
    {
        IEnumerable<Itens> ObterTodosItens();
        void Cadastrar(Itens itens);
        void Atualizar(Itens itens);
        Itens ObterItens(int id);
        void Excluir(int id);
    }
}
