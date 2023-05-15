namespace bmarketo.ViewModel
{
    public class GridCollectionItemViewModel
    {
        public string Id { get; set; } = null!;
        public string ProductImage { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public decimal? OldPrice { get; set; }


    }
}
