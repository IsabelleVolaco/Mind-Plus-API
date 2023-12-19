using Mind_Plus_API_Isabelle.DTO;
using Mind_Plus_API_Isabelle.Entity;

namespace Mind_Plus_API_Isabelle.Contracts
{
    public interface IEmployeesRepository
    {
        Task AddEmployee(EmployeesDTO employee);  
        Task UpdateEmployee(EmployeesEntity employee);
        Task DeleteEmployee(int id); // [lembrete no EmployeesRepository]
        Task<IEnumerable<EmployeesEntity>> ViewEmployee(); //[id]


        // Task<UserTokenDTO> LogIn(UserLoginDTO user);
    }
}
