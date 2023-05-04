using System.ComponentModel.DataAnnotations;
using bmarketo.Models.Entities;

namespace bmarketo.ViewModel
{
    public class ProductRegistrationViewModel
    {
        public int Id { get; set; }
      
        [Required(ErrorMessage = "You have to name the product")]
        [Display(Name = "*Product Name:")]
        public string Name { get; set; } = null!;

        public string ProductImage { get; set; } = null!;

        [Display(Name = "Product Description:")]
        public string? Description { get; set; } = null!;

        [Required(ErrorMessage = "You have to choose a price for the product.")]
        [Display(Name = "*Product Price:")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public static implicit operator ProductEntity(ProductRegistrationViewModel productRegistrationViewModel)
        {
            return new ProductEntity
            {
                Name = productRegistrationViewModel.Name,
                Description = productRegistrationViewModel.Description,
                Price = productRegistrationViewModel.Price,
                ProductImage = productRegistrationViewModel.ProductImage,
            };
        }




    }
}



