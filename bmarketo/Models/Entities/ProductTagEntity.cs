using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace bmarketo.Models.Entities
{
    [PrimaryKey(nameof(ArticleNumber), nameof(TagId))]
 
    public class ProductTagEntity
    {
        // ändra tillbaka till string om det ej går. 
    
        public string ArticleNumber { get; set; } = null!;

 
        public ProductEntity Product { get; set; } = null!;

        public int TagId { get; set; }

     
        public TagEntity Tag { get; set; } = null!;
    }
}
