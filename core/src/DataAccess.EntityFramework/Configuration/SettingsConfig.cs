/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using DataAccess.EntityFramework.Configuration.System;
using Entities;

namespace DataAccess.EntityFramework.Configuration
{
    public class SettingsConfig : BaseEntityConfig<Settings>
    {
        public SettingsConfig() : base("Settings")
        {
            Property(obj => obj.ThemeName).HasColumnName("ThemeName").IsRequired();
        }
    }
}