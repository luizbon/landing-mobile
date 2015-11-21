using System.Collections.Generic;
using System.Threading.Tasks;
using Landing.Api.Rest;

namespace Landing.Api.Connectors
{
    public class DefaultConnector<TInterface, TModel> : BaseConnector<TInterface> where TInterface : IDefault<TModel>
    {
        public DefaultConnector(string token) : base(token)
        {
        }

        public async Task<List<TModel>> GetListAsync(int pageSize = 50, int page = 0)
        {
            return await Rest.List(pageSize, pageSize * page);
        }

        public async Task<TModel> GetAsync(int id)
        {
            return await Rest.Get(id);
        }
    }
}