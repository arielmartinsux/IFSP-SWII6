using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// CB3021521 - Gabriel Martins Alves da Silva

namespace TP03SWII6.Models
{
    [Table("produto")]
    public class Product
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("Price")]
        public decimal Price { get; set; }

        [Required]
        [Column("Quantity")]
        public int Quantity { get; set; }
    }
}
