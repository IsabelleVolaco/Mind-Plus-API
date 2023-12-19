using Microsoft.AspNetCore.Mvc;
using Mind_Plus_API_Isabelle.Contracts;
using Mind_Plus_API_Isabelle.Repository;

namespace Mind_Plus_API_Isabelle.Controllers
{
    [ApiController]
    [Route("colaboradores/login")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        //[Authorize]
        [HttpGet] //[substituir por post]
        public async Task<IActionResult> VerifyLogin(string email, string password)
        {
            return Ok(await _loginRepository.VerifyLogin(email, password)); //try catch vai aqui com a mensagem de erro > utiliza/retorna   ---  BAD REQUEST
        }
    }

    /*
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login (LoginDTO user) //Falta criar as pastas respectivas e transferir informações
        {
            try
            {
                return Ok(await _userRepository.LogIn(user));
            } catch (Exception ex)
            {
                return Unauthorized("Usuário ou senha invalidos");
            }
        }

        [HttpPost]
        [Route("salarios")]
        [Authorize(Roles = "admin")] //-------------- PERMITE QUE ESTES ACESSEM SUAS RESPECTIVAS INFORMAÇÕES (Quais são os seus papéis)
        
        public string Salarios() = Salario; // Permissionamento do backend ---> vai liberar os endpoints apenas para quem tem a permissão (Respectivamente)

     

        [HttpPost]
        [Route("funcionarios")]
        [Authorize(Roles = "default")]
    
         public string Funcionarios() = Funcionario;  
        
        
        
    */
}
