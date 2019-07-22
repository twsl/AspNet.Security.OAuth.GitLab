using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using AspNet.Security.OAuth.GitLab;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods to add GitLab authentication capabilities to an HTTP application pipeline.
    /// </summary>
    public static class GitLabAuthenticationExtensions
    {
        /// <summary>
        /// Adds <see cref="GitLabAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Discord authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddGitLab(this AuthenticationBuilder builder)
            => builder.AddGitLab(GitLabAuthenticationDefaults.AuthenticationScheme, _ => { });


        /// <summary>
        /// Adds <see cref="GitLabAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Discord authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="configuration">The delegate used to configure the OpenID 2.0 options.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddGitLab(this AuthenticationBuilder builder, Action<GitLabAuthenticationOptions> configuration)
            => builder.AddGitLab(GitLabAuthenticationDefaults.AuthenticationScheme, configuration);


        /// <summary>
        /// Adds <see cref="GitLabAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Discord authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the Discord options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddGitLab(this AuthenticationBuilder builder, string scheme, Action<GitLabAuthenticationOptions> configuration)
            => builder.AddGitLab(scheme, GitLabAuthenticationDefaults.DisplayName, configuration);



        /// <summary>
        /// Adds <see cref="GitLabAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Discord authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="caption">The optional display name associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the Discord options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddGitLab(this AuthenticationBuilder builder, string scheme, string caption, Action<GitLabAuthenticationOptions> configuration)
            => builder.AddOAuth<GitLabAuthenticationOptions, GitLabAuthenticationHandler>(scheme, caption, configuration);
    }
}
