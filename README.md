# AspNet.Security.OAuth.GitLab
OAuth2 GitLab authentication provider for ASP.NET Core

# Background
In order to make this available to a wider range of people, I decided to push this to the [AspNet.Security.OAuth.Providers](https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers) repository instead of publishing the nuget package on my own. 

## Usage
Head over to [AspNet.Security.OAuth.Providers](https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers) and use the appropriate nuget package.

Make sure, to update the ClientId and ClientSecret, eigher in the `appsettings.json`:
```json
"Authentication": {
    "GitLab": {
      "ClientId": "...",
      "ClientSecret": "..."
    }
  }
```

 or directly within the code:
 ```csharp
 services.AddAuthentication().AddGitLab(options =>
    {
        // Provide the GitLab Client ID
        options.ClientId = "...";
        // Provide the GitLab Secret
        options.ClientSecret = "...";
    });
 ```