namespace TejuanaAdmin.ViewModel
{
    public class ProductSupplyVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}