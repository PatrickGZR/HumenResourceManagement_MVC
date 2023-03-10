using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;
using HRM.ApplicationCore.Contract.Repository;
using HRM.ApplicationCore.Contract.Service;
using HRM.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Infrastructure.Service
{
    public class UserServiceAsync : IUserServiceAsync
    {
        private readonly IUserRepositoryAsync userRepositoryAsync;

        public UserServiceAsync(IUserRepositoryAsync _userRepositoryAsync)
        {
            userRepositoryAsync = _userRepositoryAsync;
        }

        public Task<int> AddUserAsync(UserRequestModel model)
        {
            User user = new User()
            {
                UserName = model.UserName,
                EmailId = model.EmailId,
                Password = model.Password
            };
            return userRepositoryAsync.InsertAsync(user);
        }

        public Task<int> DeleteUserAsync(int id)
        {
            return userRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserResponseModel>> GetAllUsersAsync()
        {
            var result = await userRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new UserResponseModel()
                { Id = x.Id, EmailId = x.EmailId, Password = x.Password, Username = x.UserName });
            }
            return null;
        }

        public async Task<UserResponseModel> GetUserByIdAsync(int id)
        {
            var result = await userRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new UserResponseModel()
                {
                    Id = result.Id,
                    EmailId = result.EmailId,
                    Password = result.Password,
                    Username = result.UserName
                };
            }
            return null;
        }

        public Task<int> UpdateUserAsync(UserRequestModel model)
        {
            User user = new User()
            {
                UserName = model.UserName,
                EmailId = model.EmailId,
                Password = model.Password
            };
            return userRepositoryAsync.UpdateAsync(user);
        }
    }
}