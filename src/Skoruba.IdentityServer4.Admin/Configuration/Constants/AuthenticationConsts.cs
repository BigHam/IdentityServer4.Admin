﻿using System.Collections.Generic;

namespace Skoruba.IdentityServer4.Admin.Configuration.Constants
{
    public class AuthenticationConsts
    {
        public const string IdentityAdminCookieName = "IdentityServerAdmin";
        public const string UserNameClaimType = "name";
        public const string SignInScheme = "Cookies";
        public const string OidcClientId = "skoruba_identity_admin";
        public const string OidcClientSecret = "skoruba_admin_client_secret";
        public const string OidcAuthenticationScheme = "oidc";
        public const string OidcResponseType = "code id_token";
        public static List<string> Scopes = new List<string> { ScopeOpenId, ScopeProfile, ScopeEmail, ScopeRoles };

        public const string IdentityAdminApiSwaggerClientId = "skoruba_identity_admin_api_swaggerui";
        public const string IdentityAdminApiScope = "skoruba_identity_admin_api";

        public const string ScopeOpenId = "openid";
        public const string ScopeProfile = "profile";
        public const string ScopeEmail = "email";
        public const string ScopeRoles = "roles";

        public const string RoleClaim = "role";

        public const string AccountLoginPage = "Account/Login";
        public const string AccountAccessDeniedPage = "/Account/AccessDenied/";
    }
}