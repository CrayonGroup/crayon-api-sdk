using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class SubscriptionResource
    {
        private readonly CrayonApiClient _client;

        public SubscriptionResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<Subscription>> Get(string token, SubscriptionFilter filter = null)
        {
            var uri = "/api/v1/subscriptions/".Append(filter);
            return _client.Get<ApiCollection<Subscription>>(token, uri);
        }

        public CrayonApiClientResult<SubscriptionDetailed> GetById(string token, int id)
        {
            string uri = $"/api/v1/subscriptions/{id}";
            return _client.Get<SubscriptionDetailed>(token, uri);
        }

        public CrayonApiClientResult<SubscriptionDetailed> Create(string token, SubscriptionDetailed subscription)
        {
            var uri = "/api/v1/subscriptions/";
            return _client.Post<SubscriptionDetailed>(token, uri, subscription);
        }

        public CrayonApiClientResult<SubscriptionDetailed> Update(string token, SubscriptionDetailed subscription)
        {
            Guard.NotNull(subscription, nameof(subscription));

            var uri = $"/api/v1/subscriptions/{subscription.Id}";
            return _client.Put<SubscriptionDetailed>(token, uri, subscription);
        }
    }
}