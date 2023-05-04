namespace bmarketo.ViewModel
{
    public class HomeIndexViewModel
    {
        public string Title { get; set; } = "Home";
        public GridCollectionViewModel BestCollection { get; set; } = null!;
        public GridCollectionViewModel PercentageOffBox { get; set; } = null!;

        public GridCollectionViewModel TopSelling { get; set; } = null!;
    }
} 
