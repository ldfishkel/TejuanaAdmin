namespace TejuanaAdmin.Daos
{
    using System;
    using System.Collections.Generic;
    using ViewModel.Order;

    public class OrderDao
    {
        public List<OrderVM> GetOrderList()
        {
            List<OrderVM> supplies = new List<OrderVM>();

            for (int i = 0; i < 20; i++)
            {
                supplies.Add(new OrderVM()
                {
                    Id = i,
                    ClientId = i,
                    ProductName = "nombre " + i,
                    ProductAmount = 5,
                    EstimatedDate = DateTime.Now,
                });
            }

            return supplies;
        }
    }
}
