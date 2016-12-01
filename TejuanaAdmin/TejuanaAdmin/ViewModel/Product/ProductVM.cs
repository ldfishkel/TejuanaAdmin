namespace TejuanaAdmin.ViewModel
{
    using System.Collections.Generic;

    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductTypeVM Type { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int AvgProductionTime { get; set; }
        public string ImageURL { get; set; }
        public HashSet<ProductSupplyVM> Supplies { get; set; }
        public string Size { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
