using System.ComponentModel.DataAnnotations;

namespace Crud_Api.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}
