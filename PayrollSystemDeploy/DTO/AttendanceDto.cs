namespace PayrollWebApp.DTO
{
    public class AttendanceDto
    {

        public string? Code { get; set; }       
        public long EmployeeID { get; set; }          // NUMERIC(18,0)
        public long AttendanceMonth { get; set; }   // FLOAT
        public long AttendanceYear { get; set; }    // FLOAT
        public double? TotalWorkingDays { get; set; }
        public double? HalfDays { get; set; }
        public double? CL { get; set; }
        public double? SL { get; set; }
        public double? PL { get; set; }
        public double? Other1 { get; set; }
        public double? Other2 { get; set; }
        public double? Other3 { get; set; }
        public double? NoOfPresentDays { get; set; }
        public double? AbsentDays { get; set; }
        public double? ExtraHourWork { get; set; }
        public double? TotalDays { get; set; }
        public long DeptID { get; set; }
        public long SectionID { get; set; }
        public string? CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string? TrUser { get; set; }
        public DateTime? TrDate { get; set; }
        public string Deleted { get; set; } = "N";
    }

}
