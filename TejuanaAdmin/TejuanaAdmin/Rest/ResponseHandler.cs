namespace TejuanaAdmin.Rest
{
    using Contracts;
    using Newtonsoft.Json;
    using RestSharp;
    using System.Text;

    public class ResponseHandler<T> : IResponse
    {
        private IRestResponse _response;

        public ResponseHandler(IRestResponse response)
        {
            _response = response;   
        }

        public T Content
        {
            get
            {
                if (Ok)
                    return JsonConvert.DeserializeObject<T>(_response.Content);
                else
                    throw new HttpException(this);
            }
        }

        public string ErrorMessage()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_response.StatusCode.ToString());
            sb.AppendLine("\nMensaje:");
            sb.AppendLine(_response.Content);
            return sb.ToString();
        }

        public bool Ok
        {
            get
            {
                return _response.StatusCode == System.Net.HttpStatusCode.Accepted ||
                       _response.StatusCode == System.Net.HttpStatusCode.OK ||
                       _response.StatusCode == System.Net.HttpStatusCode.Created ||
                       _response.StatusCode == System.Net.HttpStatusCode.NoContent ||
                       _response.StatusCode == System.Net.HttpStatusCode.ResetContent ||
                       _response.StatusCode == System.Net.HttpStatusCode.PartialContent;
            }

        }
    }
}
