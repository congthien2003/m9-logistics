/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the �docs� folder for license information on type of purchased license.
*/

using WebApi.Filters;
using System.Web.Http.Filters;

namespace WebApi
{
    public static class FilterConfig
    {
        public static void RegisterFilters(HttpFilterCollection filters)
        {
            filters.Add(new WebApiExceptionFilterAttribute());
        }
    }
}