namespace PayrollWebApp.DTO
{
    public class EmployeeForm16Dto  // for generate form16
    {
        public string? ClientName { get; set; }
        public string? ClientAddress { get; set; }
        public string? EmployerName { get; set; }
        public string? ClientPAN { get; set; }
        public string? TAN { get; set; }

        public string? EmployeeCode { get; set; }
        public string? EmployeePAN { get; set; }
        public string? EmployeeName { get; set; }
        public string? DesignationName { get; set; }

        public decimal TotalPF { get; set; }
        public decimal TotalAllowance { get; set; }
    }
}
