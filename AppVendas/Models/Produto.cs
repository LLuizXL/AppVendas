using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Insira o nome do produto!")]
        [MaxLength(100, ErrorMessage = "O campo deve ter no máximo, 100 caracteres!")]
        [MinLength(3, ErrorMessage = "O campo deve ter no mínimo, 3 caracteres!")]
        public string ProdutoNome { get; set; }



        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Insira o valor do produto!")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do produto deve ser um número positivo!")]
        public double Valor { get; set; }



        [Display(Name = "Estoque Disponível")]
        [Required(ErrorMessage = "Insira a quantidade do estoque!")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do produto deve ser um número positivo!")]
        public double QtdEstoque { get; set; }




        [Display(Name = "Ativo?")]
        public bool CadastroAtivo { get; set; } = true;

        //Chave Estrangeira

        [Required(ErrorMessage = "Por favor, selecione uma categoria!")]
        [Display(Name = "Categoria")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }
}
