using System.ComponentModel.DataAnnotations;

namespace EF_CF_MultiTables_Demo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Product> Products {get; set;}
    }
}
