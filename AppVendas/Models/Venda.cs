using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }

        [Display(Name = "Nota Fiscal")]
        public int NotaFiscal { get; set; }


        [Display(Name = "Data da venda")]
        public DateTime DataVenda { get; set; }

        [Display(Name = "Valor total")]
        public double? TotalVenda { get; set; }

        [Display(Name = "Itens vendidos")]
        public Guid ItemDaVendaId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
