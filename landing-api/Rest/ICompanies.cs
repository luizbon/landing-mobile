using System.Collections.Generic;
using System.Threading.Tasks;
using Landing.Api.Models;
using Refit;

namespace Landing.Api.Rest
{
    [Headers("Authorization: Token")]
    public interface ICompanies : IDefault<Company>
    {
        [Get("/companies?limit={take}&offset={skip}")]
        new Task<List<Company>> List(int take = 50, int skip = 0);

        [Get("/companies/{id}")]
        new Task<Company> Get(int id);
    }
}