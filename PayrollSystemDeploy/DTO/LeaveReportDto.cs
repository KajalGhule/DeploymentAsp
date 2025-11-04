namespace PayrollWebApp.DTO
{
    public class LeaveReportDto
    {
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string LeaveCode { get; set; }
        public int TotalDaysApproved { get; set; }
    }

}
