namespace Mind_Plus_API_Isabelle.DTO
{
    public class EmployeesDTO
    {
        //Criação de colaborador pelo admin

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; } //Verificar necessidade uso de int ou str
        public string Address { get; set; }
        public string Office { get; set; }
        public string Company { get; set; } //Business no HTML
        public string Password { get; set; }
        public string Contract { get; set; }



        public string Role { get; set; } //aula 19.12
    }
}
