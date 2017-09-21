// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Authentication.OpenIdConnect
{
    public class SignedOutRedirectContext : RemoteAuthenticationContext<OpenIdConnectOptions>
    {
        public SignedOutRedirectContext(HttpContext context, AuthenticationScheme scheme, OpenIdConnectOptions options, AuthenticationProperties properties)
            : base(context, scheme, options, properties)
        {
        }
    }
}