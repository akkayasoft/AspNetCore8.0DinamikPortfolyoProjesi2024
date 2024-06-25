using System.ComponentModel.DataAnnotations;

namespace AspNetCore8._0DinamikPortfolyoProjesi2024.Veritabani.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaId { get; set; }
        public string HakkimizdaAdi { get; set; }
        public string HakkimizdaAciklama { get; set; }

        public string HakkimizdaResim { get; set; }
    }
}
