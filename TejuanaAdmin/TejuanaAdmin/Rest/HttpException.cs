namespace TejuanaAdmin.Rest
{
    using Contracts;
    using System;

    public class HttpException : Exception
    {
        private IResponse _response;
        public IResponse Response
        {
            get
            {
                return _response;
            }
        }

        public HttpException(IResponse response) : base (response.ErrorMessage())
        {
            _response = response;
        }
    }
}
