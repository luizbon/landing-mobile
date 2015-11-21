using System.Threading.Tasks;
using Landing.Api.Models;
using Refit;

namespace Landing.Api.Rest
{
    [Headers("Authorization: Token")]
    public interface IUser
    {
        [Get("/user")]
        Task<User> Get();
    }
}