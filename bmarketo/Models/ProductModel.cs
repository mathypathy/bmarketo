
using bmarketo.Models.Entities;
using bmarketo.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace bmarketo.Models
{
    public class ProductModel
    {

       
        public string Name { get; set; } = null!; 
        public string Description { get; set; } = null!;
        public decimal? Price { get; set; }
        public decimal? OldPrice { get; set; }
        public string ArticleNumber { get; set; } = null!;
        public string? ProductImage { get; set; } = null!;

   
    }










}
