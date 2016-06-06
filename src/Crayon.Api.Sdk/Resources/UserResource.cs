using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class UserResource
    {
        private readonly CrayonApiClient _client;

        public UserResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<User>> Get(string token, UserFilter filter = null)
        {
            var uri = "/api/v1/users/".Append(filter);
            return _client.Get<ApiCollection<User>>(token, uri);
        }

        public CrayonApiClientResult<User> GetById(string token, string id)
        {
            var uri = $"/api/v1/users/{id}/";
            return _client.Get<User>(token, uri);
        }

        public CrayonApiClientResult<User> GetByUserName(string token, string name)
        {
            var uri = $"/api/v1/users/user/?userName={name}";
            return _client.Get<User>(token, uri);
        }

        public CrayonApiClientResult<User> Create(string token, User user)
        {
            var uri = "/api/v1/users/";
            return _client.Post<User>(token, uri, user);
        }

        public CrayonApiClientResult<User> Update(string token, User user)
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

        public virtual CrayonApiClientResult<bool> ChangePassword(string token, string userId, string newPassword)
        {
            var uri = $"/api/v1/users/{userId}/changepassword/";
            return _client.Put<bool>(token, uri, new UserChangePassword { UserId = userId, NewPassword = newPassword });
        }

        public virtual CrayonApiClientResult<bool> ChangePassword(string token, string userId, string oldPassword, string newPassword)
        {
            var uri = $"/api/v1/users/{userId}/changepassword/";
            return _client.Put<bool>(token, uri, new UserChangePassword { UserId = userId, OldPassword = oldPassword, NewPassword = newPassword });
        }
    }
}