using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Resources
{
    public class ResellerSalesPriceResource
    {
        private readonly CrayonApiClient _client;

        public ResellerSalesPriceResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<IEnumerable<ResellerSalesPrice>> Get(string token, ResellerSalesPriceFilter filter = null)
        {
            var uri = "api/v1/resellersalesprices/".Append(filter);
            return _client.Get<IEnumerable<ResellerSalesPrice>>(token, uri);
        }

        public async Task<CrayonApiClientResult<IEnumerable<ResellerSalesPrice>>> GetAsync(string token, ResellerSalesPriceFilter filter = null)
        {
            var uri = "api/v1/resellersalesprices/".Append(filter);
            return await _client.GetAsync<IEnumerable<ResellerSalesPrice>>(token, uri);
        }

        public CrayonApiClientResult<ResellerSalesPrice> GetCurrent(string token, ResellerSalesPriceFilter filter = null)
        {
            var uri = "api/v1/resellersalesprices/current/".Append(filter);
            return _client.Get<ResellerSalesPrice>(token, uri);
        }

        public async Task<CrayonApiClientResult<ResellerSalesPrice>> GetCurrentAsync(string token, ResellerSalesPriceFilter filter = null)
        {
            var uri = "api/v1/resellersalesprices/current/".Append(filter);
            return await _client.GetAsync<ResellerSalesPrice>(token, uri);
        }

        public CrayonApiClientResult<ResellerSalesPrice> Create(string token, ResellerSalesPrice resellerSalesPrice)
        {
            var uri = "api/v1/resellersalesprices/";
            return _client.Post<ResellerSalesPrice>(token, uri, resellerSalesPrice);
        }

        public async Task<CrayonApiClientResult<ResellerSalesPrice>> CreateAsync(string token, ResellerSalesPrice resellerSalesPrice)
        {
            var uri = "api/v1/resellersalesprices/";
            return await _client.PostAsync<ResellerSalesPrice>(token, uri, resellerSalesPrice);
        }

        public CrayonApiClientResult<ResellerSalesPrice> Update(string token, DateTimeOffset oldFromDate, ResellerSalesPrice resellerSalesPrice)
        {
            Guard.NotNull(resellerSalesPrice, nameof(resellerSalesPrice));

            var uri = $"api/v1/resellersalesprices/";
            return _client.Put<ResellerSalesPrice>(token, uri, resellerSalesPrice);
        }

        public async Task<CrayonApiClientResult<ResellerSalesPrice>> UpdateAsync(string token, DateTimeOffset oldFromDate, ResellerSalesPrice resellerSalesPrice)
        {
            Guard.NotNull(resellerSalesPrice, nameof(resellerSalesPrice));

            var uri = $"api/v1/resellersalesprices/";
            return await _client.PutAsync<ResellerSalesPrice>(token, uri, resellerSalesPrice);
        }

        public CrayonApiClientResult DeleteByFilter(string token, ResellerSalesPriceFilter filter)
        {
            var uri = $"/api/v1/resellersalesprices/".Append(filter);
            return _client.Delete(token, uri);
        }

        public async Task<CrayonApiClientResult> DeleteByFilterAsync(string token, ResellerSalesPriceFilter filter)
        {
            var uri = $"/api/v1/resellersalesprices/".Append(filter);
            return await _client.DeleteAsync(token, uri);
        }
        public CrayonApiClientResult Toggle(string token, ResellerSalesPriceToggle resellerSalesPriceToggle)
        {
            var uri = "api/v1/resellersalesprices/toggle";
            return _client.Post<ResellerSalesPrice>(token, uri, resellerSalesPriceToggle);
        }

        public async Task<CrayonApiClientResult> ToggleAsync(string token, ResellerSalesPriceToggle resellerSalesPriceToggle)
        {
            var uri = "api/v1/resellersalesprices/toggle";
            return await _client.PostAsync<ResellerSalesPrice>(token, uri, resellerSalesPriceToggle);
        }
    }
}
