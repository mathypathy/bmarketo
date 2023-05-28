using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bmarketo.Models.Entities
{
    public class ProductEntity
    {
        [Key]
     
        public string ArticleNumber { get; set; } = null!;
        public string? Name { get; set; } = null!;
        public string? Description { get; set; }
        [Column(TypeName="money")]
        public decimal? Price { get; set; }
        public string? ProductImage { get; set; } = null!;
        [Column(TypeName = "money")]
        public decimal? OldPrice { get; set; }
       

 

        public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();

        public static implicit operator ProductModel(ProductEntity entity)
        {
            return new ProductModel
            {
               
                Name = entity.Name,
                Description = entity?.Description,
                Price = entity?.Price,
                ProductImage = entity?.ProductImage,
                ArticleNumber = entity?.ArticleNumber,
                
               OldPrice = entity?.OldPrice,
            };
        }
    }
}
