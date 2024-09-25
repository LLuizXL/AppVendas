using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Insira o nome do produto!")]
        public string ProdutoNome { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Insira o valor do produto!")]
        public double Valor { get; set; }

        [Display(Name = "Estoque Disponível")]
        [Required(ErrorMessage = "Insira a quantidade do estoque!")]
        public double QtdEstoque { get; set; }


        [Display(Name = "Ativo?")]
        public bool CadastroAtivo { get; set; }

        //Chave Estrangeira
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }
}
