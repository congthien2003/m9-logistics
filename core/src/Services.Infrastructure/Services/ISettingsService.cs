/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using DTO;
using System.Threading.Tasks;

namespace Services.Infrastructure
{
    public interface ISettingsService
    {
        Task<SettingsDTO> GetById(int id);

        Task<SettingsDTO> Edit(SettingsDTO settings);
    }
}