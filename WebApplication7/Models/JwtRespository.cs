using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class JwtRespository
    {

        public string SecretKey { get; set; }
        public int TokenDuration { get; set; }
        public object Configuration { get; private set; }

        private readonly IConfiguration Config;

        public JwtRespository(IConfiguration _Config)
        {
            Config = _Config;
            this.SecretKey = Config.GetSection("jwt").GetSection("key").Value;
            this.TokenDuration = Int32.Parse(Config.GetSection("jwt").GetSection("Duration").Value);

        }
        public string GenerateToken(string id, string username)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.SecretKey));
            var signature = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var payload = new[]
            {

                new Claim("id",id),
                 new Claim("username",username),
                 
            };

            var jwtToken = new JwtSecurityToken(
                issuer: "localhost",
                audience: "localhost",
                claims: payload,

                expires: DateTime.Now.AddMinutes(TokenDuration),
                signingCredentials: signature
                );
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);

        }
        //public string AdminToken(string id, string username, string email, String Role)
        //{
        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.SecretKey));
        //    var signature = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        //    var payload = new[]
        //    {

        //        new Claim("id",id),
        //         new Claim("username",username),
        //          new Claim("email",email),
        //          new Claim("Role",Role)

        //    };

        //    var jwtToken = new JwtSecurityToken(
        //        // issuer: "Admin",
        //        // audience: "Admin",
        //        claims: payload,

        //        expires: DateTime.Now.AddMinutes(TokenDuration),
        //        signingCredentials: signature
        //        );
        //    return new JwtSecurityTokenHandler().WriteToken(jwtToken);

        //}
    }
}
