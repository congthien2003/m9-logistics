/*
* Copyright (c) M9 Logistics 2023. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the �docs� folder for license information on type of purchased license.
*/

using Swashbuckle.Application;
using System.Web.Http;

namespace WebApi
{
    public static class SwaggerConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            config.EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Web Api");
                    c.ApiKey("Token")
                        .Description("JWT token here")
                        .Name("Authorization")
                        .In("header");
                })
                .EnableSwaggerUi(c =>
                {
                    c.EnableApiKeySupport("Authorization", "header");
                });
        }
    }
}