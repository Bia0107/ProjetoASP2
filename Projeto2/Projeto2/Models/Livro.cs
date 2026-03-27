using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projeto2.Models
{
    public class Livro
    {
        public int CodLivro { get; set; }
        [DisplayName("XYZ")]
        public string NomeLivro { get; set; }
        public string ImagemLivro { get; set; }
        public string Quantidade { get; set; }
    }
}
