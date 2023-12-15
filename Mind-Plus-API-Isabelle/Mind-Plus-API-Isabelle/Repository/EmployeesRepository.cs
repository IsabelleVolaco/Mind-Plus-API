using Dapper;
using Mind_Plus_API_Isabelle.Contracts;
using Mind_Plus_API_Isabelle.DTO;
using Mind_Plus_API_Isabelle.Entity;
using Mind_Plus_API_Isabelle.Infraestructure;

namespace Mind_Plus_API_Isabelle.Repository
{
    public class EmployeesRepository : Connection, IEmployeesRepository
    {
        //create -- ADICIONAR colaborador
        public async Task AddEmployee(EmployeesDTO employee) 
        {
            string sql = @"
                INSERT INTO colaboradores (Name, Email, Phone, Address, Office, Company, Password, Contract)
                            VALUE (@Name, @Email, @Phone, @Address, @Office, @Company, @Password, @Contract)
            ";
            await Execute(sql, employee); 
        }

        //update -- ALTERAR colaborador
        public async Task UpdateEmployee(EmployeesEntity employee)
        {
            string sql = @"
                UPDATE colaboradores
                   SET Name = @Name, 
                       Email = @Email, 
                       Phone = @Phone,
                       Address = @Address,
                       Office = @Office,
                       Company = @Company,
                       Password = @Password,
                       Contract = @Contract
                 WHERE Id = @Id
            ";
            await Execute(sql, employee);
        }

        /*-
        ------------------------------------------------------------------------------------------------=
        ***** [A IDEIA FUTURAMENTE É SUBSTITUIR O DELETE DAQUI POR UM PUT] -> Arquivamento de dados *****
        //update -- REMOVER colaborador
        public async Task DeleteEmployee(EmployeesEntity employee)
        {
            string sql = @"
                UPDATE COLABORADORES
                   SET active = false
                 WHERE Id = @Id
            ";
            await Execute(sql, employee);
        }
        ------------------------------------------------------------------------------------------------=
        */

        //delete -- REMOVER colaborador
        public async Task DeleteEmployee(int id)
        {
            string sql = @"DELETE FROM colaboradores WHERE Id = @id";
            await Execute(sql, new { id });
        }

        //read
        public async Task<IEnumerable<EmployeesEntity>> ViewEmployee()
        {
            string sql = @"SELECT * FROM colaboradores";
            return await GetConnection().QueryAsync<EmployeesEntity>(sql);
        }


        public async Task<EmployeesEntity> GetById(int id)
        {
            string sql = "SELECT * FROM colaboradores WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<EmployeesEntity>(sql, new { id });
        }








    }
}
