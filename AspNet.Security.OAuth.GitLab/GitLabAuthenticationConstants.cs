namespace AspNet.Security.OAuth.GitLab
{
    /// <summary>
    /// Contains constants specific to the <see cref="GitLabAuthenticationHandler"/>.
    /// </summary>
    public static class GitLabAuthenticationConstants
    {
        public static class Claims
        {
            public const string Name = "urn:gitlab:name";
            public const string Avatar = "urn:gitlab:avatar";
            public const string Url = "urn:gitlab:url";
        }
    }
}
