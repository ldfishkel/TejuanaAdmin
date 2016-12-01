namespace TejuanaAdmin.Daos
{
    using Rest;
    using RestSharp;
    using System.Collections.Generic;
    using TejuanaAdmin.ViewModel;
    using ViewModel.Product;

    public class ProductDao
    {
        private readonly RequestHandler _requestHandler;

        public ProductDao(RequestHandler requestHandler)
        {
            _requestHandler = requestHandler;
        }

        public List<ProductVM> GetProducts()
        {
            var response = _requestHandler.Request<List<ProductVM>>(RequestPaths.ProductList, Method.GET);

            return response.Content;
        }

        public List<TagVM> GetTags()
        {
            var response = _requestHandler.Request<List<TagVM>>(RequestPaths.TagList, Method.GET);

            return response.Content;
        }

        public void AddTag(TagVM tag)
        {
            _requestHandler.Request(RequestPaths.AddTag, Method.POST, tag);
        }

        public void AddProductType(ProductTypeVM productType)
        {
            _requestHandler.Request(RequestPaths.AddProductType, Method.POST, productType);
        }

        public List<ProductTypeVM> GetProductTypes()
        {
            var response = _requestHandler.Request<List<ProductTypeVM>>(RequestPaths.ProductTypeList, Method.GET);

            return response.Content;
        }

        public List<ProductVM> GetProducts(ProductTypeVM type)
        {
            var response = _requestHandler.Request<List<ProductVM>>(RequestPaths.ProductListBy, type.Id.ToString(), Method.GET);

            return response.Content;
        }

        public void AddProduct(ProductVM product)
        {
            _requestHandler.Request(RequestPaths.AddProduct, Method.POST, product);
        }

        public void UpdateProduct(ProductVM product)
        {
            _requestHandler.Request(RequestPaths.UpdateProduct, Method.PUT, product);
        }
    }
}
