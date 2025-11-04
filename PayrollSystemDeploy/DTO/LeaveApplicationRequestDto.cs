namespace PayrollWebApp.DTO
{
    public class LeaveApplicationRequestDto
    {
        public int EmployeeID { get; set; }
        public string EmployeeCode {  get; set; }
        public int LeaveTypeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Reason { get; set; }

        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string Deleted { get; set; } = "N";

    }
}
