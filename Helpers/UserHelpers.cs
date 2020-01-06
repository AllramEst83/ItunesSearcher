using ItunesSearcher.Interfaces;
using System.Security.Claims;
using System.Security.Principal;

public static class UserHelper
{
    public static string GetUserId(this IPrincipal principal)
    {
        ClaimsIdentity claimsIdentity = (ClaimsIdentity)principal.Identity;
        Claim claim = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
        return claim.Value;
    }
}