namespace PayrollWebApp.DTO
{
    public class LeaveDto
    {
        public int LeaveTypeID { get; set; }
        public string LeaveCode { get; set; }
        public string LeaveName { get; set; }
        public decimal MaxPerYear { get; set; }
    }
}
