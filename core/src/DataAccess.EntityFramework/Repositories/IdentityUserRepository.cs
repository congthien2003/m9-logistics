﻿/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Entities;
using Services.Infrastructure;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class IdentityUserRepository : BaseDeletableRepository<User, DataContext>, IIdentityUserRepository<User>
    {
        public override async Task<User> Edit(User obj, ContextSession session)
        {
            var objectExists = await Exists(obj, session, true);
            using (var context = GetContext(session))
            {
                context.Entry(obj).State = objectExists ? EntityState.Modified : EntityState.Added;
                await context.SaveChangesAsync();
                return obj;
            }
        }

        public override async Task<User> Get(int id, ContextSession session, bool includeDeleted = false)
        {
            using (var context = GetContext(session))
            {
                return await GetEntities(context, includeDeleted)
                    .Where(obj => obj.Id == id)
                    .Include(u => u.Claims)
                    .Include(u => u.UserRoles.Select(r => r.Role))
                    .FirstOrDefaultAsync();
            }
        }

        public async Task<User> GetByLogin(string login, ContextSession session, bool includeDeleted = false)
        {
            using (var context = GetContext(session))
            {
                return await GetEntities(context, includeDeleted)
                    .Where(obj => obj.Login == login)
                    .Include(u => u.Claims)
                    .Include(u => u.UserRoles.Select(r => r.Role))
                    .FirstOrDefaultAsync();
            }
        }

        public async Task<User> GetByEmail(string email, ContextSession session, bool includeDeleted = false)
        {
            using (var context = GetContext(session))
            {
                return await GetEntities(context, includeDeleted)
                    .Where(obj => obj.Email == email)
                    .Include(u => u.Claims)
                    .Include(u => u.UserRoles.Select(r => r.Role))
                    .FirstOrDefaultAsync();
            }
        }

        public Task<User> GetById(int id, ContextSession session, bool includeDeleted = false)
        {
            return Get(id, session, includeDeleted);
        }

        public async Task<IList<User>> GetUsersByRole(int roleId, ContextSession session, bool includeDeleted = false)
        {
            using (var context = GetContext(session))
            {
                return await GetEntities(context, includeDeleted)
                    .Include(u => u.Claims)
                    .Include(u => u.UserRoles.Select(r => r.Role))
                    .Where(x => x.UserRoles.Any(ur => ur.RoleId == roleId))
                    .ToArrayAsync();
            }
        }

        public async Task<IList<User>> GetUsersByClaim(string claimType, string claimValue, ContextSession session, bool includeDeleted = false)
        {
            using (var context = GetContext(session))
            {
                return await GetEntities(context, includeDeleted)
                    .Include(u => u.Claims)
                    .Include(u => u.UserRoles)
                    .Include(u => u.UserRoles.Select(r => r.Role))
                    .Where(x => x.Claims.Any(cl => cl.ClaimType == claimType && cl.ClaimValue == claimValue))
                    .ToArrayAsync();
            }
        }
    }
}
