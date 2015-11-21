using Landing.Api.Connectors;
using Landing.Api.Models;
using Landing.Api.Rest;

namespace Landing.Api
{
    public class Connector
    {
        private readonly string _token;

        public Connector(string token)
        {
            _token = token;
        }

        public DefaultConnector<ICompanies, Company> Company => new DefaultConnector<ICompanies, Company>(_token);

        public DefaultConnector<IJobOffers, JobOffer> JobOffer => new DefaultConnector<IJobOffers, JobOffer>(_token);

        public UserConnector User => new UserConnector(_token);

        public DefaultConnector<IApplications, Application> Application
            => new DefaultConnector<IApplications, Application>(_token);

        public ReferralConnector Referral => new ReferralConnector(_token);

        public RecomentationConnector Recomendation => new RecomentationConnector(_token);
    }
}