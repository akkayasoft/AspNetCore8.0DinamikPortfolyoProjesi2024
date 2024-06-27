using System.ComponentModel.DataAnnotations;

namespace AspNetCore8._0DinamikPortfolyoProjesi2024.Veritabani.Siniflar
{
    public class Calismalar
    {
        [Key]
        public int CalismaId { get; set; }
        public string CalismaAdi { get; set; }
        public string CalismaAciklama { get; set; }


    }
}
