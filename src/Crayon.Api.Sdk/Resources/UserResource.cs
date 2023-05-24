using System.Net;
using System.Threading.Tasks;
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

        public async Task<CrayonApiClientResult<ApiCollection<User>>> GetAsync(string token, UserFilter filter = null)
        {
            var uri = "/api/v1/users/".Append(filter);
            return await _client.GetAsync<ApiCollection<User>>(token, uri);
        }

        public CrayonApiClientResult<User> GetById(string token, string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ApiHttpException(HttpStatusCode.BadRequest, "Id is required");
            }

            var uri = $"/api/v1/users/{id}/";
            return _client.Get<User>(token, uri);
        }

        public async Task<CrayonApiClientResult<User>> GetByIdAsync(string token, string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ApiHttpException(HttpStatusCode.BadRequest, "Id is required");
            }

            var uri = $"/api/v1/users/{id}/";
            return await _client.GetAsync<User>(token, uri);
        }

        public CrayonApiClientResult<User> GetByUserName(string token, string name)
        {
            var uri = $"/api/v1/users/user/?userName={name}";
            return _client.Get<User>(token, uri);
        }

        public async Task<CrayonApiClientResult<User>> GetByUserNameAsync(string token, string name)
        {
            var uri = $"/api/v1/users/user/?userName={name}";
            return await _client.GetAsync<User>(token, uri);
        }

        public CrayonApiClientResult<User> Create(string token, UserUpsert user)
        {
            var uri = "/api/v1/users/";
            return _client.Post<User>(token, uri, user);
        }

        public async Task<CrayonApiClientResult<User>> CreateAsync(string token, UserUpsert user)
        {
            var uri = "/api/v1/users/";
            return await _client.PostAsync<User>(token, uri, user);
        }

        public CrayonApiClientResult<User> Update(string token, UserUpsert user)
        {
            Guard.NotNull(user, nameof(user));

            if (string.IsNullOrWhiteSpace(user.Id))
            {
                throw new ApiHttpException(HttpStatusCode.BadRequest, "Id is required");
            }

            var uri = $"/api/v1/users/{user.Id}/";
            return _client.Put<User>(token, uri, user);
        }

        public async Task<CrayonApiClientResult<User>> UpdateAsync(string token, UserUpsert user)
        {
            Guard.NotNull(user, nameof(user));

            if (string.IsNullOrWhiteSpace(user.Id))
            {
                throw new ApiHttpException(HttpStatusCode.BadRequest, "Id is required");
            }

            var uri = $"/api/v1/users/{user.Id}/";
            return await _client.PutAsync<User>(token, uri, user);
        }

        public CrayonApiClientResult Delete(string token, string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ApiHttpException(HttpStatusCode.BadRequest, "Id is required");
            }

            var uri = $"/api/v1/users/{id}/";
            return _client.Delete(token, uri);
        }

        public async Task<CrayonApiClientResult> DeleteAsync(string token, string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ApiHttpException(HttpStatusCode.BadRequest, "Id is required");
            }

            var uri = $"/api/v1/users/{id}/";
            return await _client.DeleteAsync(token, uri);
        }

        public CrayonApiClientResult<bool> ChangePassword(string token, string userId, string newPassword)
        {
            return ChangePassword(token, userId, null, newPassword);
        }

        public CrayonApiClientResult<bool> ChangePassword(string token, string userId, string oldPassword, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ApiHttpException(HttpStatusCode.BadRequest, "Id is required");
            }

            var uri = $"/api/v1/users/{userId}/changepassword/";
            return _client.Put<bool>(token, uri, new UserChangePassword { UserId = userId, OldPassword = oldPassword, NewPassword = newPassword });
        }

        public async Task<CrayonApiClientResult<bool>> ChangePasswordAsync(string token, string userId, string newPassword)
        {
            return await ChangePasswordAsync(token, userId, null, newPassword);
        }

        public async Task<CrayonApiClientResult<bool>> ChangePasswordAsync(string token, string userId, string oldPassword, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ApiHttpException(HttpStatusCode.BadRequest, "Id is required");
            }
            var uri = $"/api/v1/users/{userId}/changepassword/";
            return await _client.PutAsync<bool>(token, uri, new UserChangePassword { UserId = userId, OldPassword = oldPassword, NewPassword = newPassword });
        }
    }
}