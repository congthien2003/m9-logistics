﻿/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using AutoMapper;
using DTO;
using Entities;

namespace Services.Infrastructure.MappingProfiles
{
    public class SettingsProfile : Profile
    {
        public SettingsProfile()
        {
            CreateMap<Settings, SettingsDTO>().ReverseMap();
        }
    }
}
