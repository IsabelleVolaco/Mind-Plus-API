namespace Mind_Plus_API_Isabelle.DTO
{
    public class FormsDTO
    {
        public int FTAnswer { get; set; } //Formulário de Satisfação no Trabalho
        public int FPAnswer { get; set; } //Formulário de Satisfação Pessoal
        public int FEAnswer { get; set; } //Formulário de Identificação de Fatores de Estresse
        public int FAAnswer { get; set; } //Formulário de Autocuidado
        public int SGAnswer { get; set; } //Satisfação Geral dos Colaboradores
        public int colaboradores_Id { get; set; } //ID do colaborador
    }
}
