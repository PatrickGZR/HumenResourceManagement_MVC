﻿using HRM.ApplicationCore.Model.Request;
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
    public class UserRoleServiceAsync : IUserRoleServiceAsync
    {
        private readonly IUserRoleRepositoryAsync userRoleRepositoryAsync;

        public UserRoleServiceAsync(IUserRoleRepositoryAsync _userRoleRepositoryAsync)
        {
            userRoleRepositoryAsync = _userRoleRepositoryAsync;
        }

        public Task<int> AddUserRoleAsync(UserRoleRequestModel model)
        {
            UserRole userRole = new UserRole()
            {
                UserId = model.UserId,
                RoleId = model.RoleId
            };
            return userRoleRepositoryAsync.InsertAsync(userRole);
        }

        public Task<int> DeleteUserRoleAsync(int id)
        {
            return userRoleRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserRoleResponseModel>> GetAllUserRolesAsync()
        {
            var result = await userRoleRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new UserRoleResponseModel()
                { Id = x.Id, UserId = x.UserId, RoleId = x.RoleId });
            }
            return null;
        }

        public async Task<UserRoleResponseModel> GetUserRoleByIdAsync(int id)
        {
            var result = await userRoleRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new UserRoleResponseModel()
                {
                    Id = result.Id,
                    UserId = result.UserId,
                    RoleId = result.RoleId
                };
            }
            return null;
        }

        public Task<int> UpdateUserRoleAsync(UserRoleRequestModel model)
        {
            UserRole userRole = new UserRole()
            {
                UserId = model.UserId,
                RoleId = model.RoleId
            };
            return userRoleRepositoryAsync.UpdateAsync(userRole);
        }
    }
}
