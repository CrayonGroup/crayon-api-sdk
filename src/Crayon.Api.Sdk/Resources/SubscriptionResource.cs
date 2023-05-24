using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;
using Crayon.Api.Sdk.Extensions;
using Crayon.Api.Sdk.Filtering;
using System.Linq;

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

        public async Task<CrayonApiClientResult<ApiCollection<Subscription>>> GetAsync(string token, SubscriptionFilter filter = null)
        {
            var uri = "/api/v1/subscriptions/".Append(filter);
            return await _client.GetAsync<ApiCollection<Subscription>>(token, uri);
        }

        public CrayonApiClientResult<SubscriptionDetailed> GetById(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<SubscriptionDetailed>();
            }

            string uri = $"/api/v1/subscriptions/{id}";
            return _client.Get<SubscriptionDetailed>(token, uri);
        }

        public async Task<CrayonApiClientResult<SubscriptionDetailed>> GetByIdAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<SubscriptionDetailed>();
            }

            string uri = $"/api/v1/subscriptions/{id}";
            return await _client.GetAsync<SubscriptionDetailed>(token, uri);
        }

        public CrayonApiRequest<SubscriptionDetailed> Create(string token, SubscriptionDetailed subscription)
        {
            return new CrayonApiRequest<SubscriptionDetailed>(async options =>
            {
                var uri = "/api/v1/subscriptions/";
                return await _client.PostAsync<SubscriptionDetailed>(token, uri, subscription, options);
            }, options =>
            {
                var uri = "/api/v1/subscriptions/";
                return _client.Post<SubscriptionDetailed>(token, uri, subscription, options);
            });
        }

        public async Task<CrayonApiClientResult<SubscriptionDetailed>> CreateAsync(string token, SubscriptionDetailed subscription)
        {
            return await Create(token, subscription).ResultAsync();
        }

        public CrayonApiClientResult<SubscriptionDetailed> Update(string token, SubscriptionDetailed subscription)
        {
            Guard.NotNull(subscription, nameof(subscription));

            var uri = $"/api/v1/subscriptions/{subscription.Id}";
            return _client.Put<SubscriptionDetailed>(token, uri, subscription);
        }

        public async Task<CrayonApiClientResult<SubscriptionDetailed>> UpdateAsync(string token, SubscriptionDetailed subscription)
        {
            Guard.NotNull(subscription, nameof(subscription));

            var uri = $"/api/v1/subscriptions/{subscription.Id}";
            return await _client.PutAsync<SubscriptionDetailed>(token, uri, subscription);
        }

        public async Task<CrayonApiClientResult<NewCommerceOrderResult>> PostNewCommerceOrderAsync(string token, NewCommerceOrder newOrder)
        {
            Guard.NotNull(newOrder, nameof(newOrder));

            var uri = "/api/v1/subscriptions/new-commerce-orders";
            return await _client.PostAsync<NewCommerceOrderResult>(token, uri, newOrder);
        }

        public async Task<CrayonApiClientResult<NextTermInstructionsResult>> PostNextTermInstructionsAsync(string token, int subscriptionId, NextTermInstructions newInstructions)
        {
            Guard.NotNull(newInstructions, nameof(newInstructions));

            var uri = $"/api/v1/subscriptions/{subscriptionId}/next-term-instructions";
            return await _client.PostAsync<NextTermInstructionsResult>(token, uri, newInstructions);
        }

        public CrayonApiClientResult<ApiCollection<SubscriptionConversion>> GetSubscriptionConversions(string token, int subscriptionId)
        {
            var uri = $"/api/v1/subscriptions/{subscriptionId}/conversions";
            return _client.Get<ApiCollection<SubscriptionConversion>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<SubscriptionConversion>>> GetSubscriptionConversionsAsync(string token, int subscriptionId)
        {
            var uri = $"/api/v1/subscriptions/{subscriptionId}/conversions";
            return await _client.GetAsync<ApiCollection<SubscriptionConversion>>(token, uri);
        }

        public CrayonApiClientResult<ActivationLink> GetActivationLink(string token, int id)
        {
            var uri = $"/api/v1/subscriptions/{id}/activationlink/";
            return _client.Get<ActivationLink>(token, uri);
        }

        public async Task<CrayonApiClientResult<ActivationLink>> GetActivationLinkAsync(string token, int id)
        {
            var uri = $"/api/v1/subscriptions/{id}/activationlink/";
            return await _client.GetAsync<ActivationLink>(token, uri);
        }

        public async Task<CrayonApiClientResult<bool>> GetIsRegisteredReservedInstance(string token, int id, bool reservedInstance)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<bool>();
            }

            var uri = $"/api/v1/subscriptions/{reservedInstance}/subscriptionId/{id}";
            return await _client.GetAsync<bool>(token, uri);
        }

        public async Task<CrayonApiClientResult<bool>> RegisterReservedInstance(string token, int id, bool reservedInstance)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<bool>();
            }

            var uri = $"/api/v1/subscriptions/{reservedInstance}/subscriptionId/{id}";
            return await _client.PostAsync<bool>(token, uri, null);
        }

        public CrayonApiClientResult<SubscriptionDetailed> PostSubscriptionConversion(string token, int subscriptionId, SubscriptionConversion conversion)
        {
            var uri = $"/api/v1/subscriptions/{subscriptionId}/conversions";
            return _client.Post<SubscriptionDetailed>(token, uri, conversion);
        }

        public async Task<CrayonApiClientResult<SubscriptionDetailed>> PostSubscriptionConversionAsync(string token, int subscriptionId, SubscriptionConversion conversion)
        {
            var uri = $"/api/v1/subscriptions/{subscriptionId}/conversions";
            return await _client.PostAsync<SubscriptionDetailed>(token, uri, conversion);
        }

        public CrayonApiClientResult<ApiCollection<SubscriptionTransitionEligibility>> GetTransitionEligibilities(string token, int id, string eligibilityType)
        {
            var uri = $"/api/v1/subscriptions/{id}/transition-eligibilities/{eligibilityType}";
            return _client.Get<ApiCollection<SubscriptionTransitionEligibility>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<SubscriptionTransitionEligibility>>> GetTransitionEligibilitiesAsync(string token, int id, string eligibilityType)
        {
            var uri = $"/api/v1/subscriptions/{id}/transition-eligibilities/{eligibilityType}";
            return await _client.GetAsync<ApiCollection<SubscriptionTransitionEligibility>>(token, uri);
        }

        public CrayonApiClientResult<ApiCollection<SubscriptionTransitionResponse>> GetTransitions(string token, int id)
        {
            var uri = $"/api/v1/subscriptions/{id}/transitions/";
            return _client.Get<ApiCollection<SubscriptionTransitionResponse>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<SubscriptionTransitionResponse>>> GetTransitionsAsync(string token, int id)
        {
            var uri = $"/api/v1/subscriptions/{id}/transitions/";
            return await _client.GetAsync<ApiCollection<SubscriptionTransitionResponse>>(token, uri);
        }

        public CrayonApiClientResult<SubscriptionTransitionResponse> PostTransition(string token, int id, SubscriptionTransition transition)
        {
            var uri = $"/api/v1/subscriptions/{id}/transition/";
            return _client.Post<SubscriptionTransitionResponse>(token, uri, transition);
        }

        public async Task<CrayonApiClientResult<SubscriptionTransitionResponse>> PostTransitionAsync(string token, int id, SubscriptionTransition transition)
        {
            var uri = $"/api/v1/subscriptions/{id}/transition/";
            return await _client.PostAsync<SubscriptionTransitionResponse>(token, uri, transition);
        }

        public CrayonApiClientResult<ApiCollection<ObjectReference>> GetSubscriptionPriceTypes()
        {
            return new CrayonApiClientResult<ApiCollection<ObjectReference>>(EnumExtensions.GetValues<SubscriptionPriceType>(), HttpStatusCode.OK);
        }

        public async Task<CrayonApiClientResult<SubscriptionTags>> GetSubscriptionTagsAsync(string token, int subscriptionId)
        {
            var uri = $"/api/v1/subscriptions/{subscriptionId}/tags";
            return await _client.GetAsync<SubscriptionTags>(token, uri);
        }

        public async Task<CrayonApiClientResult<bool>> SetSubscriptionTagsAsync(string token, SubscriptionTags tags)
        {
            var uri = $"/api/v1/subscriptions/{tags.SubscriptionId}/tags";
            return await _client.PostAsync<bool>(token, uri, tags);
        }

        public async Task<CrayonApiClientResult<bool>> SetSubscriptionAddon(string token, PostSubscriptionAddOn addOn, int subscriptionId)
        {
            var uri = $"/api/v1/subscriptions/{subscriptionId}/addons";
            return await _client.PostAsync<bool>(token, uri, addOn);
        }

        public async Task<CrayonApiClientResult<ApiCollection<SubscriptionAddOnOffer>>> GetSubscriptionAddons(string token, int subscriptionId)
        {
            var uri = $"/api/v1/subscriptions/{subscriptionId}/addon-offers";
            return await _client.GetAsync<ApiCollection<SubscriptionAddOnOffer>>(token, uri);
        }

        public async Task<CrayonApiClientResult> DeleteSubscriptionTagsAsync(string token, int subscriptionId)
        {
            var uri = $"/api/v1/subscriptions/{subscriptionId}/tags";
            return await _client.DeleteAsync(token, uri);
        }

        public async Task<CrayonApiClientResult<CoterminositySubscriptions>> GetCoterminositySubscriptionsAsync(string token, SubscriptionCoterminosityFilter filter)
        {
            var uri = "/api/v1/subscriptions/coterminosity/".Append(filter);
            return await _client.GetAsync<CoterminositySubscriptions>(token, uri);
        }
    }
}