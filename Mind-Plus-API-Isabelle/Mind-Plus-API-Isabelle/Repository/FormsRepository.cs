using Dapper;
using Mind_Plus_API_Isabelle.Contracts;
using Mind_Plus_API_Isabelle.DTO;
using Mind_Plus_API_Isabelle.Entity;
using Mind_Plus_API_Isabelle.Infraestructure;

namespace Mind_Plus_API_Isabelle.Repository
{
    public class FormsRepository : Connection, IFormsRepository
    {
        public async Task FormDone(FormsDTO form)
        {
            string sql = @"
                INSERT INTO forms (FTAnswer, FPAnswer, FEAnswer, FAAnswer, SGAnswer, colaboradores_Id)
                    VALUE (@FTAnswer, @FPAnswer, @FEAnswer, @FAAnswer, @SGAnswer, @colaboradores_Id)
            ";
            await Execute(sql, form);
        }

        public async Task<IEnumerable<FormsEntity>> ViewForm()
        {
            string sql = @"SELECT * FROM forms";
            return await GetConnection().QueryAsync<FormsEntity>(sql);
        }
    }
}
