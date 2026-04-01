using MySql.Data.MySqlClient;
using Projeto2.Models;
using Projeto2.Repositorio.Contrato;
using System.Data;
using static Mysqlx.Expect.Open.Types.Condition.Types;

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

                MySqlCommand cmd = new MySqlCommand("insert into tbLivro values(default, @NomeLivro, @ImagemLivro", conexao);
                cmd.Parameters.Add("@NomeLivro", MySqlDbType.VarChar).Value = livro.NomeLivro;
                cmd.Parameters.Add("@ImagemLivro", MySqlDbType.VarChar).Value = livro.ImagemLivro;

                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }

        public Livro ObterLivros(int Id)
        {
            using (var conexao = new MySqlConnection())
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("select * from tbLivro where CodLivro=@CodLivro", conexao);
                cmd.Parameters.Add("@CodLivro", MySqlDbType.VarChar).Value = Id;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                MySqlDataReader dr;

                Livro livro = new Livro();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    livro.CodLivro = Convert.ToInt32(dr["CodLivro"]);
                    livro.NomeLivro = (String)(dr["NomeLivro"]);
                    livro.ImagemLivro = (String)(dr["ImagemLivro"]);
                }
                return livro;
            }
        }

        public IEnumerable<Livro> ObterTodosLivros()
        {
            List<Livro> Livrolist = new List<Livro>();
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select * from tbLivro", conexao);
                MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sd.Fill(dt);
                conexao.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    Livrolist.Add(
                        new Livro
                        {
                            CodLivro = Convert.ToInt32(dr["CodLivro"]),
                            NomeLivro = (String)(dr["NomeLivro"]),
                            ImagemLivro = (String)(dr["ImagemLivro"]),

                        });
                }
                return Livrolist;
            }
        }
    }
}
