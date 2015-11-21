using System.Collections.Generic;
using System.Threading.Tasks;

namespace Landing.Api.Rest
{
    public interface IDefault<TModel>
    {
        Task<List<TModel>> List(int take = 50, int skip = 0);
        Task<TModel> Get(int id);
    }
}