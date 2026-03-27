using MySql.Data.MySqlClient;
using Projeto2.Models;
using Projeto2.Repositorio.Contrato;

namespace Projeto2.Repositorio
{
    public class LivrosRepositorio : ILivrosRepositorio
    {
        private readonly string _conexaoMySQL;
        public LivrosRepositorio(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySql");
        }

        public void Atualizar(Livro livro)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Livro livro)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("insert into tbLivro values(default, @NomeLivro")
            }
        }

        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }

        public Livro ObterLivros(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> ObterTodosLivros()
        {
            throw new NotImplementedException();
        }
    }
}
