using System.Threading.Tasks;
using Landing.Api.Models;
using Landing.Api.Rest;

namespace Landing.Api.Connectors
{
    public class UserConnector : BaseConnector<IUser>
    {
        public UserConnector(string token) : base(token)
        {
        }

        public async Task<User> GetAsync()
        {
            return await Rest.Get();
        }
    }
}