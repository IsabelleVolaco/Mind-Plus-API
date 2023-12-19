using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mind_Plus_API_Isabelle.Contracts;
using Mind_Plus_API_Isabelle.DTO;
using Mind_Plus_API_Isabelle.Entity;


namespace Mind_Plus_API_Isabelle.Controllers
{
    [ApiController]
    [Route("colaboradores")] 
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesRepository _employeesRepository; 

        public EmployeesController(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        [HttpPost] //create
        public async Task<IActionResult> AddEmployee(EmployeesDTO employee)
        {
            await _employeesRepository.AddEmployee(employee);
            return Ok("Colaborador cadastrado");
        }

        [HttpPut] //update
        public async Task<IActionResult> UpdateEmployee(EmployeesEntity employee)
        {
            await _employeesRepository.UpdateEmployee(employee); 
            return Ok("Colaborador atualizado");
        }

        [HttpDelete] //delete
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _employeesRepository.DeleteEmployee(id);
            return Ok("Colaborador removido");
        }

        [HttpGet] //read
        public async Task<IActionResult> ViewEmployee()
        {
            return Ok(await _employeesRepository.ViewEmployee());
        }

        //a verificar
        [HttpPost]
        [Route("salarios")]
        [Authorize(Roles = "admin")] //-------------- PERMITE QUE ESTES ACESSEM SUAS RESPECTIVAS INFORMAÇÕES (Quais são os seus papéis)

        public string Salarios() => "Salario"; // Permissionamento do backend ---> vai liberar os endpoints apenas para quem tem a permissão (Respectivamente)


        [HttpPost]
        [Route("funcionarios")]
        [Authorize(Roles = "default")]

        public string Funcionarios() => "Funcionarios";
    }
}
