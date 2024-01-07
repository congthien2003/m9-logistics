/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the �docs� folder for license information on type of purchased license.
*/

using AutoMapper.Configuration;
using Services.Infrastructure.MappingProfiles;

namespace WebApi
{
    public static class AutoMapperConfig
    {
        public static void Configure(MapperConfigurationExpression config)
        {
            config.AllowNullCollections = false;

            config.AddProfile<IdentityUserProfile>();
            config.AddProfile<UserProfile>();
            config.AddProfile<SettingsProfile>();
        }
    }
}