namespace PayrollWebApp.DTO
{
    public class UpdateLeaveStatusRequestDto
    {
        public long LeaveAppID { get; set; }     // Matches DB column
        public string Status { get; set; }       // "Approved" or "Rejected"
        public long ApproverID { get; set; }     // FK from UserMaster.UserID
        //public string? Remarks { get; set; } 
        public string TrUser { get; set; }       // Who is updating
    }
}
