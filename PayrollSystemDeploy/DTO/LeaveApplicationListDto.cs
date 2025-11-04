namespace PayrollWebApp.DTO
{
    public class LeaveApplicationListDto
    {
        public int LeaveAppID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public string LeaveName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double NoOfDays { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        //public DateTime ApplyDate { get; set; }
    }
}
