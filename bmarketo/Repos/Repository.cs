using bmarketo.Contexts;
using bmarketo.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace bmarketo.Repos
{
    public abstract class Repository<TEntity> where TEntity : class
    {
        private readonly DataContext _context;
        protected Repository(DataContext context)
        {
            _context = context;
        }
        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
            if (entity != null) 
                return entity;
            return null!;
        }
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().Where(expression).ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllTagsAsync()
        {
            var entities = await _context.Set<TEntity>().ToListAsync();
            return entities;
        }
        
        public virtual async Task<TEntity>UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public virtual async Task<bool> DeleteAsync(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch { };
            return false;

         
        }

        public virtual async Task<IEnumerable<ProductModel>> GetProductsByTagAsync(string tagName)
        {
            var products = await _context.Products.Include(p => p.ProductTags).ThenInclude(pt => pt.Tag).
                Where(p => p.ProductTags.Any(pt => pt.Tag.TagName == tagName)).ToListAsync();

            return products.Select(p=>(ProductModel)p).ToList();
        }


    }
}
