using Dapper;
using Mind_Plus_API_Isabelle.Contracts;
using Mind_Plus_API_Isabelle.Entity;
using Mind_Plus_API_Isabelle.Infraestructure;

namespace Mind_Plus_API_Isabelle.Repository
{
    public class LoginRepository : Connection, ILoginRepository
    {
        public async Task<EmployeesEntity> VerifyLogin(string email, string password)
        {
            string sql = "SELECT * FROM colaboradores WHERE Email like @email AND Password like @password";
            return await GetConnection().QueryFirstAsync<EmployeesEntity>(sql, new { email, password });
        }
    }
}
