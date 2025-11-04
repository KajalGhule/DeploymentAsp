namespace PayrollWebApp.DTO
{
    public class SalaryRegisterRequest
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int? DepartmentId { get; set; }
        public int? SectionId { get; set; }
    }
}
