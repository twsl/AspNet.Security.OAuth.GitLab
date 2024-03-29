﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;
using static AspNet.Security.OAuth.GitLab.GitLabAuthenticationConstants;

namespace AspNet.Security.OAuth.GitLab
{
    public class GitLabAuthenticationOptions : OAuthOptions
    {
        /// <summary>
        /// Initializes a new <see cref="GitLabAuthenticationOptions"/>.
        /// </summary>
        public GitLabAuthenticationOptions()
        {
            CallbackPath = new PathString(GitLabAuthenticationDefaults.CallbackPath);
            AuthorizationEndpoint = GitLabAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = GitLabAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = GitLabAuthenticationDefaults.UserInformationEndpoint;
            Scope.Add("openid");
            Scope.Add("profile");
            Scope.Add("email");
            Scope.Add("read_user");

            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "username");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "email");
            ClaimActions.MapJsonKey(Claims.Name, "name");
            ClaimActions.MapJsonKey(Claims.Avatar, "avatar_url");
            ClaimActions.MapJsonKey(Claims.Url, "web_url");
        }

        /// <summary>
        /// access_type. Set to 'offline' to request a refresh token.
        /// </summary>
        public string AccessType { get; set; }
    }
}
