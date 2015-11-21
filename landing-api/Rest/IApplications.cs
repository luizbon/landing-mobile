using System.Collections.Generic;
using System.Threading.Tasks;
using Landing.Api.Models;
using Refit;

namespace Landing.Api.Rest
{
    [Headers("Authorization: Token")]
    public interface IApplications : IDefault<Application>
    {
        [Get("/user/applications?limit={take}&offset={skip}")]
        new Task<List<Application>> List(int take = 50, int skip = 0);

        [Get("/user/applications/{id}")]
        new Task<Application> Get(int id);
    }
}