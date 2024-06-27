using System.ComponentModel.DataAnnotations;

namespace AspNetCore8._0DinamikPortfolyoProjesi2024.Veritabani.Siniflar
{
    public class Admin
    {
        [Key]
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
