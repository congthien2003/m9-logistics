﻿/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Entities;
using Services.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class RoleRepository : BaseRepository<Role, DataContext>, IRoleRepository<Role>
    {
        public async Task<Role> Get(string name, ContextSession session)
        {
            using (var context = GetContext(session))
            {
                return await GetEntities(context).Where(obj => obj.Name == name).FirstOrDefaultAsync();
            }
        }
    }
}