using LojaShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaShopping.ProductAPI.Model
{
    [Table("product")]
    public class Product : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name {get; set;}

        [Column("price")]
        [Required]
        [Range(1, 1000)]
        public decimal Price { get; set;}

        [Column("description")]
        [StringLength(500)]
        public string Description { get; set;}

        [Column("category_name")]
        [StringLength(50)]
        public string CategoryName { get; set;}

        [Column("image_url")]
        // URLS so funcionam acima de 255 caractres acima disso precisa mandar via BODY não pela URL
        [StringLength (300)]
        public string ImageURL { get; set;}
      
    }
}
