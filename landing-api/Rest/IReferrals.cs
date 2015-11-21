using System.Collections.Generic;
using System.Threading.Tasks;
using Landing.Api.Models;
using Refit;

namespace Landing.Api.Rest
{
    [Headers("Authorization: Token")]
    public interface IReferrals
    {
        [Get("/user/referrals_received?limit={take}&offset={skip}")]
        Task<List<Referral>> Received(int take = 50, int skip = 0);

        [Get("/user/referrals_sent?limit={take}&offset={skip}")]
        Task<List<Referral>> Sent(int take = 50, int skip = 0);

        [Get("/user/referrals/{id}")]
        Task<Referral> Get(int id);
    }
}