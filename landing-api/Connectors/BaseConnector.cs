using System;
using System.Net.Http;
using Landing.Api.Rest;
using Refit;

namespace Landing.Api.Connectors
{
    public abstract class BaseConnector<TInterface>
    {
        private readonly string _token;

        protected BaseConnector(string token)
        {
            _token = token;
        }

        protected TInterface Rest => RestService.For<TInterface>(new HttpClient(new TokenHttpClientHandler(_token))
        {
            BaseAddress = new Uri("https://landing.jobs/api/v1")
        });
    }
}