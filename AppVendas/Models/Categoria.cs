using System.ComponentModel.DataAnnotations;
namespace AppVendas.Models
{
    public class Categoria
    {

        public Guid CategoriaId { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [MaxLength(ErrorMessage = "Deve ter no máximo, 100 caracteres!")]
        public string CategoriaNome { get; set; }


    }
}
