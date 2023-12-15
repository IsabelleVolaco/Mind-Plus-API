using Microsoft.AspNetCore.Mvc;
using Mind_Plus_API_Isabelle.Contracts;
using Mind_Plus_API_Isabelle.DTO;
using Mind_Plus_API_Isabelle.Repository;


namespace Mind_Plus_API_Isabelle.Controllers
{
    [ApiController]
    [Route("forms")]
    public class FormsController : ControllerBase
    {
        private readonly IFormsRepository _formsRepository;

        public FormsController(IFormsRepository formsRepository)
        {
            _formsRepository = formsRepository;
        }

        [HttpPost]
        public async Task<IActionResult> FormDone(FormsDTO form)
        {
            await _formsRepository.FormDone(form);
            return Ok("Avaliação realizada");
        }

        [HttpGet]
        public async Task<IActionResult> ViewForm()
        {
            return Ok(await _formsRepository.ViewForm());
        }
    }
}
