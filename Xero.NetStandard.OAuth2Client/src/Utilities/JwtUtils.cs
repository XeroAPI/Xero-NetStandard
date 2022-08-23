using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Json;
using System;
using System.Collections.Generic;


public static class JwtUtils
{
    static readonly HttpClient client = new HttpClient();

    public class JsonWebKeyList
    {
      public List<JsonWebKey> keys {get; set;}
    }

    /// <summary>
    /// Returns a decoded JwtSecurityToken given a jwt (Xero OAuth 2.0 access token or id token) 
    /// </summary>
    /// <param name="jwt">The string format of the access token or id token from OAuth 2.0</param>
    /// <returns>A decoded JwtSecurityToken with header, claim/payload and signature</returns>
    public static JwtSecurityToken decode(string jwt)
    {
      var handler = new JwtSecurityTokenHandler();
      var decodedJwt = handler.ReadJwtToken(jwt);

      return decodedJwt;
    }

    /// <summary>
    /// Returns a boolean given a Xero OAuth 2.0 access token
    /// </summary>
    /// <param name="jwt">The string format of the access token from OAuth 2.0</param>
    /// <returns>Ture if vlaidation is sucessful, false if not</returns>
    public static bool validateAccessToken(string jwt)
    {
      return validate(jwt, "https://identity.xero.com/resources");
    }

    /// <summary>
    /// Returns a boolean given a Xero OAuth 2.0 id token
    /// </summary>
    /// <param name="jwt">The string format of the Id token from OAuth 2.0</param>
    /// <param name="ClientId">Your Xero OAuth 2.0 app Client ID in string</param>
    /// <returns>Ture if vlaidation is sucessful, false if not</returns>
    public static bool validateIdToken(string jwt, string ClientId)
    {
      return validate(jwt, ClientId);
    }

    private static bool validate(string jwt, string audience)
    {
      var jwk = new JsonWebKey();
      var jwks = new JsonWebKeyList();
      var validatedJwt = new JwtSecurityToken();
      var issuer = "https://identity.xero.com";
      var handler = new JwtSecurityTokenHandler();

      using (var client = new HttpClient())
      {
          jwks = client.GetFromJsonAsync<JsonWebKeyList>("https://identity.xero.com/.well-known/openid-configuration/jwks").Result;
          jwk = jwks.keys[0];
      }

      try
      {
        var validationResult = handler.ValidateToken(jwt, new TokenValidationParameters
        {
          ValidateIssuerSigningKey = true,
          ValidateIssuer = true,
          ValidateAudience = true,
          ValidIssuer = issuer,
          ValidAudience = audience,
          IssuerSigningKey = jwk
        }, out SecurityToken validatedToken);
      }
      catch
      {
        return false;
      }
      return true;
    }
}