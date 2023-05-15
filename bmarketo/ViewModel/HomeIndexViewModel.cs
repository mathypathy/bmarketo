namespace bmarketo.ViewModel
{
    public class HomeIndexViewModel
    {
        public string Title { get; set; } = "Home";
        public GridCollectionViewModel BestCollection { get; set; } = null!;
        public GridCollectionViewModel PercentageOff { get; set; } = null!;
        public GridCollectionViewModel PercentageOff2 { get; set; } = null!;
        public GridCollectionViewModel TopSelling { get; set; } = null!;
    }
} 
