using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Landing.Api.Models;
using Refit;

namespace Landing.Api.Rest
{
    [Headers("Authorization: Token")]
    public interface IRecomentations
    {
        [Get("/user/recommendation_requests_received?limit={take}&offset={skip}")]
        Task<List<Recomendation>> Received(int take = 50, int skip = 0);

        [Get("/user/recommendation_requests_sent?limit={take}&offset={skip}")]
        Task<List<Recomendation>> Sent(int take = 50, int skip = 0);

        [Get("/user/recommendation_requests/{id}")]
        Task<Recomendation> Get(int id);
    }
}
