using System.Collections.Generic;
using System.Threading.Tasks;
using Landing.Api.Models;
using Landing.Api.Rest;

namespace Landing.Api.Connectors
{
    public class RecomentationConnector : BaseConnector<IRecomentations>
    {
        public RecomentationConnector(string token) : base(token)
        {
        }

        public async Task<List<Recomendation>> GetReceivedAsync(int pageSize = 50, int page = 0)
        {
            return await Rest.Received(pageSize, pageSize*page);
        }

        public async Task<List<Recomendation>> GetSentAsync(int pageSize = 50, int page = 0)
        {
            return await Rest.Sent(pageSize, pageSize*page);
        }

        public async Task<Recomendation> GetAsync(int id)
        {
            return await Rest.Get(id);
        }
    }
}