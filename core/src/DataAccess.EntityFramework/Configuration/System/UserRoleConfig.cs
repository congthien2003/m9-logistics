/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.EntityFramework.Configuration.System
{
    public class UserRoleConfig : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfig()
        {
            ToTable("UserRoles");
            Property(obj => obj.RoleId).HasColumnName("RoleId").IsRequired();
            Property(obj => obj.UserId).HasColumnName("UserId").IsRequired();

            HasKey(key => new { key.UserId, key.RoleId });
        }
    }
}
