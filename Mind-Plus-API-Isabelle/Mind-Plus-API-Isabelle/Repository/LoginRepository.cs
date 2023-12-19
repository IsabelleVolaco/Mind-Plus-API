using Dapper;
using Mind_Plus_API_Isabelle.Contracts;
using Mind_Plus_API_Isabelle.DTO;
using Mind_Plus_API_Isabelle.Entity;
using Mind_Plus_API_Isabelle.Infraestructure;

namespace Mind_Plus_API_Isabelle.Repository
{
    public class LoginRepository : Connection, ILoginRepository
    {
        public async Task<EmployeesEntity> VerifyLogin(string email, string password) //utilizar token do EmployeesTokenDTO
        {
            string sql = "SELECT * FROM colaboradores WHERE Email like @email AND Password like @password"; //AND Role like @Role??
            return await GetConnection().QueryFirstAsync<EmployeesEntity>(sql, new { email, password });
        }

      
        //alterado
        public async Task<EmployeesTokenDTO> Login(EmployeesLoginDTO user)
        {
            string sql = "SELECT * FROM user WHERE Email = @Email AND Password = @Password";
            EmployeesEntity employeeLogin = await GetConnection().QueryFirstAsync<EmployeesEntity>(sql, user);
            return new EmployeesTokenDTO
            {
                Token = Authentication.GenerateToken(employeeLogin),
                Employee = employeeLogin
            };
        }
       
    }
}
