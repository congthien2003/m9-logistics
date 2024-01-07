﻿/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the �docs� folder for license information on type of purchased license.
*/

using WebApi;
using System.Web.Http;

namespace WebApi
{
    public static class RouteConfig
    {
        public static void ConfigureRoutes(HttpConfiguration config)
        {
            var baseEndpoint = "api";

            config.MapHttpAttributeRoutes(new CentralizedPrefixProvider(baseEndpoint));

            config.Routes.MapHttpRoute(
                name: "Api",
                routeTemplate: $"{baseEndpoint}/{{controller}}/{{id}}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}