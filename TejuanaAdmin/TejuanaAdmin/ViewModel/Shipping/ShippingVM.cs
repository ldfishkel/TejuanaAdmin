namespace TejuanaAdmin.ViewModel.Shipping
{
    public class ShippingVM
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
