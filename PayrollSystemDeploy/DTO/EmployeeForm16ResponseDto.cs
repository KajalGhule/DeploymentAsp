namespace PayrollWebApp.DTO
{
    public class EmployeeForm16ResponseDto
    {
        public EmployeeForm16Dto EmployeeDetails { get; set; }
        public List<EmployeeForm16DeductionDto> Deductions { get; set; }
        public List<Form16AllowanceDto> Allowances { get; set; }
    }
}
