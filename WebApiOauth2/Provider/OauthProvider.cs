using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;


namespace WebApiOauth2.Provider
{
    public class OauthProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            // This method will be executed first to validate if the request has crendtials(UserName and Password)
            //if the request does not contain username and 
           //password the request will not proceded any further
            context.Validated(); 
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
           
            var identity = new ClaimsIdentity(context.Options.AuthenticationType); //it will check the authenticate type
            var user = "TestUser";
            var pwd = "testpasword";

            //Code to verify username and password are valid and Generate token

            if (user != null)
            {
                //Store information againest the request
                identity.AddClaim(new Claim("UserName", context.UserName));
                identity.AddClaim(new Claim("LoggedOn", DateTime.Now.ToString()));
                context.Validated(identity);
            }
            else
            {
                context.SetError("Wrong Crendtials", "Provided username and password is incorrect");
                context.Rejected();

            }
        }
    }
}