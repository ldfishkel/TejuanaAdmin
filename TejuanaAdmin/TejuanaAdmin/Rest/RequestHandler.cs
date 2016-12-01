namespace TejuanaAdmin.Rest
{
    using RestSharp;

    public class RequestHandler
    {
        public ResponseHandler<T> Request<T>(string path, Method method, object content = null)
        {
            var client = new RestClient(Utils.ServerUrl());

            var request = new RestRequest(path, method);

            if (content != null)
                request.AddJsonBody(content);

            return new ResponseHandler<T>(client.Execute(request));
        }

        public ResponseHandler<T> Request<T>(string path, string pathParam, Method method, object content = null)
        {
            return Request<T>(path + "/" + pathParam, method, content);
        }

        public void Request(string path, Method method, object content = null)
        {
            var client = new RestClient(Utils.ServerUrl());

            var request = new RestRequest(path, method);

            if (content != null)
                request.AddJsonBody(content);

            var response = new ResponseHandler<string>(client.Execute(request));

            if (!response.Ok)
                throw new HttpException(response);
        }

        public void Request(string path, string pathParam, Method method, object content = null)
        {
            Request(path + "/" + pathParam, method, content);
        }
    }
}
