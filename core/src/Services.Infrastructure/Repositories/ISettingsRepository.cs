/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Entities;
using System.Threading.Tasks;

namespace Services.Infrastructure
{
    public interface ISettingsRepository
    {
        Task<Settings> Get(int id, ContextSession session);
        Task<Settings> Edit(Settings setting, ContextSession session);
    }
}