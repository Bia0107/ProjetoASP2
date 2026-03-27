namespace Projeto2.Models
{
    public class Itens
    {
        public Guid ItemPedidoId { get; set; } // Guid gera gera um novo item diferente - ajuda na exclusão de itens, potque ele não puxa o id
        public int CodEmp { get; set; }
        public string CodLivro { get; set; }
        public string NomeLivro { get; set; }
        public string Imagem { get; set; }
        public string Quantidade { get; set; }
    }
}
