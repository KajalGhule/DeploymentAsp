namespace PayrollWebApp.DTO
{
    public class ApplyLeaveTrackListDto
    {
        public int LeaveAppID { get; set; }
        public string LeaveName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double NoOfDays { get; set; }
        public string Status { get; set; }
    }
}
