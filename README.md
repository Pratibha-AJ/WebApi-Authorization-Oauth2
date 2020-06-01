# WebApi-Authorization-Oauth2 - Basic


Steps:
1. Create Empty Asp.NET web application project
2. Install below dependency through Nuget Package Manager
    •	Microsoft.Owin
    •	Microsoft.Owin.Host.SystemWeb
    •	Microsoft.Owin.Security.OAuth
    •	Microsoft.Owin.Security
    •	Microsoft.AspNet.Identity.Owin
    •	Microsoft.Owin.Cors
3. Add Startup.cs file with the given code changes - Define Oauthserver options
4. Add OuthProvider - verifying the login user and then create the require identities claims and bearere access token ticket .
