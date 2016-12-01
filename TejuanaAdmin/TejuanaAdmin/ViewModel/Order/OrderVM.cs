namespace TejuanaAdmin.ViewModel.Order
{
    using System;

    public class OrderVM
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ProductName { get; set; }
        public int ProductAmount { get; set; }
        public DateTime EstimatedDate { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
