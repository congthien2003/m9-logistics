﻿/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Infrastructure
{
    public interface IUserRoleRepository<TUserRole> where TUserRole : UserRole
    {
        Task<TUserRole> Add(TUserRole userRole, ContextSession session);
        Task<TUserRole> Get(int userId, int roleId, ContextSession session);
        Task Delete(int userId, int roleId, ContextSession session);
        Task<IList<string>> GetByUserId(int userId, ContextSession session);
    }
}
