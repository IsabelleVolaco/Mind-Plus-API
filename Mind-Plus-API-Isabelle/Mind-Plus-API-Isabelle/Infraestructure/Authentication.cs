using Mind_Plus_API_Isabelle.Entity;
using System.Security.Claims;
using System.Text;

namespace Mind_Plus_API_Isabelle.Infraestructure
{
    public class Authentication //próximo passo dps de config é criar um método que gera um token --- essa classe serve apenas para gerar um token
    {
        public static string GenerateToken(EmployeesEntity employee)
        {
            var key = Encoding.ASCII.GetBytes(Configuration.JWTSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, employee.Name),
                    new Claim(ClaimTypes.Email, employee.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1), //data de expiração do token
                SigninCredentials = new SigninCredentials(new SymetricSecutiryKey(key), SecurityAlgorithm) //credenciais da assinatura do token


            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
                
                
        }
    }
}
