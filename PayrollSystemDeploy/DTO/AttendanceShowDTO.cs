namespace PayrollWebApp.DTO
{
    public class AttendanceShowDTO
    {
        public int EmployeeID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long AttendanceMonth { get; set; }
        public long AttendanceYear { get; set; }
        public decimal TotalWorkingDays { get; set; }
        public decimal HalfDays { get; set; }
        public decimal CL { get; set; }
        public decimal SL { get; set; }
        public decimal PL { get; set; }
        public decimal NoOfPresentDays { get; set; }
        public decimal AbsentDays { get; set; }
        public decimal ExtraHourWork { get; set; }
        public decimal TotalDays { get; set; }
        public int DeptID { get; set; }
    }

}
