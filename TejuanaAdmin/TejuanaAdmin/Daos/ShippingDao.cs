namespace TejuanaAdmin.Daos
{
    using System.Collections.Generic;
    using ViewModel.Shipping;

    public class ShippingDao
    {
        public List<ShippingVM> GetShippingList()
        {
            List<ShippingVM> shippings = new List<ShippingVM>();

            for (int i = 0; i < 20; i++)
            {
                shippings.Add(new ShippingVM()
                {
                    Id = i,
                    ClientId = i,
                    Address = "Direccion " + i,
                    Zipcode = "CP" + i,
                    Status = "Enviado",
                });
            }

            return shippings;
        }
    }
}
