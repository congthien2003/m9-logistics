/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Entities;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityManagement
{
    public static class UserManagerExtensions
    {
        public static async Task<ClaimsIdentity> CreateIdentityAsync<TApplicationUser>(this UserManager<TApplicationUser, int> manager, TApplicationUser user)
            where TApplicationUser : User, IUser<int>, new()
        {
            return await manager.CreateIdentityAsync(user, "JWT");
        }

    }
}
