using Crayon.Api.Sdk.Domain.CloudProvisioning.Subscriptions;
using Crayon.Api.Sdk.Filtering;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Resources
{
    public class SubscriptionResource
    {
        private readonly CrayonApiClient _client;

        public SubscriptionResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<SubscriptionCollection> Get(string token, SubscriptionFilter filter = null)
        {
            var uri = "/api/v1/subscriptions/".Append(filter);
            return _client.Get<SubscriptionCollection>(token, uri);
        }

        public CrayonApiClientDataResult<SubscriptionDetailed> GetById(string token, int id)
        {
            string uri = $"/api/v1/subscriptions/{id}";
            return _client.Get<SubscriptionDetailed>(token, uri);
        }

        public CrayonApiClientDataResult<SubscriptionDetailed> Create(string token, SubscriptionDetailed subscription)
        {
            var uri = "/api/v1/subscriptions/";
            return _client.Post<SubscriptionDetailed>(token, uri, subscription);
        }

        public CrayonApiClientDataResult<SubscriptionDetailed> Update(string token, SubscriptionDetailed subscription)
        {
            Guard.NotNull(subscription, nameof(subscription));

            var uri = $"/api/v1/subscriptions/{subscription.Id}";
            return _client.Put<SubscriptionDetailed>(token, uri, subscription);
        }
    }
}