using System.ComponentModel.DataAnnotations;

namespace AspNetCore8._0DinamikPortfolyoProjesi2024.Veritabani.Siniflar
{
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Mesaj { get; set; }
    }
}
