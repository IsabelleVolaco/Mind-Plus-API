namespace Mind_Plus_API_Isabelle.Entity
{
    public class EmployeesEntity
    {
        public int? Id { get; set; } 
        public string? Name { get; set; }
        public string? Email { get; set; } //verificar necessidade de ?
        public string? Phone { get; set; } 
        public string? Address { get; set; }
        public string? Office { get; set; }
        public string? Company { get; set; } 
        public string? Password { get; set; }
        public string? Contract { get; set; }

        public string Role { get; set; }
    }
}
