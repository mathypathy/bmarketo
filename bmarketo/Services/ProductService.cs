using bmarketo.Contexts;
using bmarketo.Models.Entities;
using bmarketo.ViewModel;
using Microsoft.EntityFrameworkCore;
using bmarketo.Models;
using bmarketo.Repos;

namespace bmarketo.Services
{
    public class ProductService
    {
        private readonly DataContext _context;
        private readonly ProductRepository _repository;
        private readonly IWebHostEnvironment _webhostEnviroment;
        public ProductService(DataContext context, ProductRepository repository, IWebHostEnvironment webHostEnvironment)
        {
            _context = context; 
            _repository = repository;
            _webhostEnviroment = webHostEnvironment;
        }

        
        public async Task<bool> CreateAsync(ProductRegistrationViewModel productRegistrationViewModel)
        {
            try
            {
                ProductEntity productEntity = productRegistrationViewModel;

                _context.Products.Add(productEntity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }


        }

        public async Task<ProductModel>CreateAsyncTwo(ProductEntity entity)
        {
            var _entity = await _repository.GetAsync(x=> x.Id == entity.Id);
            if (_entity == null)
            {
                _entity = await _repository.AddAsync(entity);
                if (_entity != null)
                    return _entity;
            }
            return null!;
        }

        public async Task<bool> UploadImageAsync(ProductModel product, IFormFile image)
        {
            try
            {


                string imagePath = $"{_webhostEnviroment.WebRootPath}/Images/products/{product.ProductImage}";
                await image.CopyToAsync(new FileStream(imagePath, FileMode.Create));
                return true;

            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            
            var items = await _context.Products.ToListAsync();
            var products = new List<ProductModel>();
            foreach(var item in items)
            {
                ProductModel productModel = item;
                products.Add(productModel);
            }

            return products;
        }

   



    }
}
