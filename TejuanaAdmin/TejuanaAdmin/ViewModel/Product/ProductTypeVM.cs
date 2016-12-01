namespace TejuanaAdmin.ViewModel
{
    using System.Collections.Generic;
    using TejuanaAdmin.ViewModel.Product;

    public class ProductTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<TagVM> Tags { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}