using System.ComponentModel.DataAnnotations;

namespace AspNetCore8._0DinamikPortfolyoProjesi2024.Veritabani.Siniflar
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string PortfolioAdi { get; set; }
        public string PortfolioAciklama { get; set; }

        public string PortfolioResim { get; set; }
    }
}
