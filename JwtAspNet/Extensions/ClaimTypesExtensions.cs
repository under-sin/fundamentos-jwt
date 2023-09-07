using System.Security.Claims;

namespace JwtAspNet.Extensions;

public static class ClaimTypesExtensions
{
    public static int GetId(this ClaimsPrincipal user)
    {
        try
        {
            var id = user.Claims.FirstOrDefault(x => x.Type == "id")!.Value;
            return int.Parse(id);
        }
        catch
        {
            return 0;
        }
    }

    public static string GetName(this ClaimsPrincipal user)
    {
        try
        {
            var name = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)!.Value;
            return name;
        }
        catch
        {
            return string.Empty;
        }
    }

    public static string GetEmail(this ClaimsPrincipal user)
    {
        try
        {
            var email = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)!.Value;
            return email;
        }
        catch
        {
            return string.Empty;
        }
    }

    public static string GetGivenName(this ClaimsPrincipal user)
    {
        try
        {
            var givenName = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.GivenName)!.Value;
            return givenName;
        }
        catch
        {
            return string.Empty;
        }
    }

    public static string GetImage(this ClaimsPrincipal user)
    {
        try
        {
            var image = user.Claims.FirstOrDefault(x => x.Type == "image")!.Value;
            return image;
        }
        catch
        {
            return string.Empty;
        }
    }
}