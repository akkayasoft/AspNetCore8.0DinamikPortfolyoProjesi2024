using System.ComponentModel.DataAnnotations;

namespace AspNetCore8._0DinamikPortfolyoProjesi2024.Veritabani.Siniflar
{
    public class Ekip
    {
        [Key]
        public int EkipId { get; set; }
        public string EkipAdi { get; set; }
        public string EkipAciklama { get; set; }

        public string EkipResim { get; set; }
    }
}
