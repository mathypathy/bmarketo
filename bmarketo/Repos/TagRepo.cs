using bmarketo.Contexts;
using bmarketo.Models.Entities;

namespace bmarketo.Repos
{
    public class TagRepository : Repository<TagEntity>
    {
        public TagRepository(DataContext context) : base(context)
        {
        }

    }
}
