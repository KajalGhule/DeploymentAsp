namespace PayrollWebApp.DTO
{
    public class AddUserRoleDto
    {
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //public string UserRoll { get; set; } // Admin / HR / Payroll

        public int UserRole { get; set; }
        public string ActivateUser { get; set; }

        public string? CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string Deleted { get; set; } = "N";
    }
}
