using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Resources
{
    public class UserResource
    {
        private readonly CrayonApiClient _client;

        public UserResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<UserCollection> Get(string token, UserFilter filter = null)
        {
            var uri = "/api/v1/users/".Append(filter);
            return _client.Get<UserCollection>(token, uri);
        }

        public CrayonApiClientDataResult<User> GetById(string token, string id)
        {
            var uri = $"/api/v1/users/{id}/";
            return _client.Get<User>(token, uri);
        }

        public CrayonApiClientDataResult<User> GetByUserName(string token, string name)
        {
            var uri = $"/api/v1/users/user/?userName={name}";
            return _client.Get<User>(token, uri);
        }

        public CrayonApiClientDataResult<User> Create(string token, User user)
        {
            var uri = "/api/v1/users/";
            return _client.Post<User>(token, uri, user);
        }

        public CrayonApiClientDataResult<User> Update(string token, User user)
        {
            Guard.NotNull(user, nameof(user));

            var uri = $"/api/v1/users/{user.Id}/";
            return _client.Put<User>(token, uri, user);
        }

        public CrayonApiClientResult Delete(string token, string id)
        {
            var uri = $"/api/v1/users/{id}/";
            return _client.Delete(token, uri);
        }

        public virtual CrayonApiClientDataResult<bool> ChangePassword(string token, string userId, string newPassword)
        {
            var uri = "/api/v1/users/user/changepassword/";
            return _client.Put<bool>(token, uri, new ChangePassword { UserId = userId, NewPassword = newPassword });
        }
    }
}