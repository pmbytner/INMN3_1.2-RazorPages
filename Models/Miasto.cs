using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INMN3_1._2_RazorPages.Models
{
    public class Miasto
    {
        public int Id { get; set; }
        public string? Nazwa { get; set; }

        public uint Populacja { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Powierzchnia { get; set; }

        [Display(Name = "Data założenia")]
        [DataType(DataType.Date)]
        public DateTime DataZałożenia { get; set; }

        public string? Województwo { get; set; }
    }
}
