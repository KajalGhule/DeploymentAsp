namespace PayrollWebApp.DTO
{
    public class EmployeeBalanceLeaveDto
    {
        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string FullName { get; set; } 
        public int EmployeeLeaveID { get; set; }
        public string LeaveCode { get; set; }
        public int Year { get; set; }
        public double PrevYear { get; set; }
        public double CurrentYear { get; set; }
        public double Balance { get; set; }
    }

}
