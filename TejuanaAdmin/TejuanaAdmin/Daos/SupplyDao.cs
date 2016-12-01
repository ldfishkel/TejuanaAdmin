
namespace TejuanaAdmin.Daos
{
    using Newtonsoft.Json;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using ViewModel;
    using ViewModel.Supply;

    public class SupplyDao
    {
        public List<SupplyVM> GetSupplies()
        {
            List<SupplyVM> supplies = new List<SupplyVM>();

            for (int i = 0; i < 20; i++)
            {
                supplies.Add(new SupplyVM()
                {
                    Id = i,
                    Name = "nombre " + i,
                    Stock = 44,
                    RealStock = -5,
                    lastTimeSupplied = DateTime.Now
                });
            }

            return supplies;
        }

        internal List<ProductSupplyVM> GetProductSupplies()
        {
            var client = new RestClient(Utils.ServerUrl());

            var request = new RestRequest("productsupplies", Method.GET);

            IRestResponse response = client.Execute(request);

            return JsonConvert.DeserializeObject<List<ProductSupplyVM>>(response.Content);
        }
    }
}
