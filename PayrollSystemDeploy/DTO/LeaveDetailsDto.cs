namespace PayrollWebApp.DTO
{
    public class LeaveDetailsDto
    {
        public string LeaveName { get; set; }
        public double LastYearBalance { get; set; }   // Opening Balance
        public double Credited { get; set; }          // Current Year balance
        public double Availed { get; set; }           // Used leaves
        public double ClosingBalance { get; set; }    // Closing = (LastYearBalance + Credited) - Availed
    }

}
