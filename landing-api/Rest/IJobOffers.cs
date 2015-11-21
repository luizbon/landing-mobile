using System.Collections.Generic;
using System.Threading.Tasks;
using Landing.Api.Models;
using Refit;

namespace Landing.Api.Rest
{
    [Headers("Authorization: Token")]
    public interface IJobOffers: IDefault<JobOffer>
    {
        [Get("/offers?limit={take}&offset={skip}")]
        new Task<List<JobOffer>> List(int take = 50, int skip = 0);

        [Get("/offers/{id}")]
        new Task<JobOffer> Get(int id);
    }
}