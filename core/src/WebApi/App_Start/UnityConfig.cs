/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ?docs? folder for license information on type of purchased license.
*/

using IdentityManagement;
using WebApi.Identity;
using DIContainer;
using Entities;
using Microsoft.AspNet.Identity;
using Unity;
using Services.Infrastructure;

namespace WebApi
{
    public static class UnityConfig
    {
        public static void RegisterDependencies(UnityContainer container)
        {
            container.RegisterType<ICurrentContextProvider, CurrentContextProvider>(new Unity.Lifetime.TransientLifetimeManager());

            container.AddExtension(new ContainerExtension());

            container.RegisterType<IRoleStore<ApplicationRole, int>, RoleStore<Role, ApplicationRole>>();
            container.RegisterType<IUserStore<ApplicationUser, int>, UserStore<User, ApplicationUser, Role, ApplicationRole, UserRole, ApplicationUserRole, UserClaim, ApplicationUserClaim>>();

            container.RegisterType<IAuthenticationService, AuthenticationService<ApplicationUser>>();
            container.RegisterType<UserManager<ApplicationUser, int>, ApplicationUserManager>();
            container.RegisterType<RoleManager<ApplicationRole, int>, ApplicationRoleManager>();
            container.RegisterType<IRoleService, RoleService<ApplicationUser, ApplicationRole>>();

            container.RegisterType<ILogger, Logger>();
        }
    }
}