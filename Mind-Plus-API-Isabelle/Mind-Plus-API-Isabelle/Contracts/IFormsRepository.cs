using Mind_Plus_API_Isabelle.DTO;
using Mind_Plus_API_Isabelle.Entity;

namespace Mind_Plus_API_Isabelle.Contracts
{
    public interface IFormsRepository
    {
        Task FormDone(FormsDTO form);
        Task<IEnumerable<FormsEntity>> ViewForm();
    }
}

