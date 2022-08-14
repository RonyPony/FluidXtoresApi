using fluidXtoresApi.Models;
using JWTWebAuthentication.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol.Core.Types;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

public class JWTManagerRepository : IJWTManagerRepository
{
    private readonly fluidContext _context;
    Dictionary<string, string> UsersRecords = new Dictionary<string, string>
    {
        { "user1","password1"},
        { "user2","password2"},
        { "user3","password3"},
    };


    private readonly IConfiguration iconfiguration;
    public JWTManagerRepository(IConfiguration iconfiguration,fluidContext ctx)
    {
        this._context = ctx;
        this.iconfiguration = iconfiguration;
    }
    public Tokens Authenticate(User users)
    {
        if (!UsersRecords.Any(x => x.Key == users.UserName && x.Value == users.UserPassword))
        {
            return null;
        }

        // Else we generate JSON Web Token
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["JWT:Key"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
          {
             new Claim(ClaimTypes.Name, users.UserName)
          }),
            Expires = DateTime.UtcNow.AddMinutes(10),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return new Tokens { Token = tokenHandler.WriteToken(token) };

    }
}   