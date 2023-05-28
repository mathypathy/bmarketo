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
        #region Constructors etc
        private readonly DataContext _context;
        private readonly ProductRepository _repository;
        private readonly ProductTagRepository _productTagRepo;
        private readonly IWebHostEnvironment _webhostEnviroment;
        public ProductService(DataContext context, ProductRepository repository, IWebHostEnvironment webHostEnvironment, ProductTagRepository productTagRepo)
        {
            _context = context;
            _repository = repository;
            _webhostEnviroment = webHostEnvironment;
            _productTagRepo = productTagRepo;
        }
        #endregion

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


        // Kanske lägga till <bool> här om det ej fungerar. 
        public async Task<ProductModel>CreateAsyncTwo(ProductEntity entity)
        {
            var _entity = await _repository.GetAsync(x=> x.ArticleNumber == entity.ArticleNumber);
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

        public async Task AddProductTagsAsync(ProductEntity entity, string[] tags)
        {
            foreach(var tag in tags)
            {
                await _productTagRepo.AddAsync(new ProductTagEntity
                {
                    ArticleNumber = entity.ArticleNumber,
                     TagId = int.Parse(tag)


                }); 
            }
        }



        public async Task<List<GridCollectionItemViewModel>> GetNewProducts()
        {

            var popularProducts = await _context.Products
             .Where(p => p.ProductTags.Any(pt => pt.Tag.TagName == "New"))
             .ToListAsync();

            // Convert the product entities to the view model
            var viewModel = popularProducts.Select(p => new GridCollectionItemViewModel
            {
                Id = p.ArticleNumber,
                Name = p.Name,
                Price = (decimal)p.Price,
                ProductImage = p.ProductImage,
                Description = p.Description,
                OldPrice = p.OldPrice
            }).ToList();

            return viewModel;




        }
        public async Task<List<GridCollectionItemViewModel>> GetPopularProducts()
        {

            var popularProducts = await _context.Products
             .Where(p => p.ProductTags.Any(pt => pt.Tag.TagName == "Popular"))
             .ToListAsync();

            // Convert the product entities to the view model
            var viewModel = popularProducts.Select(p => new GridCollectionItemViewModel
            {
                Id = p.ArticleNumber,
                Name = p.Name,
                Price = (decimal)p.Price,
                ProductImage = p.ProductImage,
                Description = p.Description,
                OldPrice = p.OldPrice
            }).ToList();

            return viewModel;




        }
        public async Task<List<GridCollectionItemViewModel>> GetFeaturedProducts()
        {

            var popularProducts = await _context.Products
             .Where(p => p.ProductTags.Any(pt => pt.Tag.TagName == "Featured"))
             .ToListAsync();

            // Convert the product entities to the view model
            var viewModel = popularProducts.Select(p => new GridCollectionItemViewModel
            {
                Id = p.ArticleNumber,
                Name = p.Name,
                Price = (decimal)p.Price,
                ProductImage = p.ProductImage,
                Description = p.Description,
                OldPrice = p.OldPrice
            }).ToList();

            return viewModel;




        }

        public async Task<List<GridCollectionItemViewModel>> GetEndProducts()
        {

            var popularProducts = await _context.Products
             .Where(p => p.ProductTags.Any(pt => pt.Tag.TagName == "RandomStuff"))
             .ToListAsync();

            // Convert the product entities to the view model
            var viewModel = popularProducts.Select(p => new GridCollectionItemViewModel
            {
                Id = p.ArticleNumber,
                Name = p.Name,
                Price = (decimal)p.Price,
                ProductImage = p.ProductImage,
                Description = p.Description,
                OldPrice = p.OldPrice
            }).ToList();

            return viewModel;




        }

    }
}
