namespace bmarketo.ViewModel
{
    public class GridCollectionViewModel
    {
        public string? Title { get; set; } = "";
        public IEnumerable<string> BreadCrumbs { get; set; } = null!;
  
        //public IEnumerable<string> Categories { get; set; } = null!;
        public IEnumerable<GridCollectionItemViewModel> GridItems { get; set; } = null!;
        public IEnumerable<ProductViewModel> Products { get; set; } = null!;
        public bool LoadMore { get; set; } = false;
       
        
        
        
                                
    }
}
