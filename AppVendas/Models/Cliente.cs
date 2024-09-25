using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }

        [Display(Name = "Nome")]
        public string ClienteNome { get; set; }

        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        public string Celular { get; set; }

        [Display(Name = "Ativo?")]
        public bool CadastroAtivvo { get; set; }

        public DateTime DataCadastro { get; set; }


    }
}
