namespace PayrollWebApp.DTO
{
    public class BonusIncentiveDTO
    {
        public int BonusIncentiveID { get; set; }
        public int EmployeeID { get; set; }
        public string? BonusName { get; set; }
        public decimal BonusAmount { get; set; }
        public int BonusMonth { get; set; }
        public int BonusYear { get; set; }
        public string? CrUser { get; set; }
        public DateTime CrDate { get; set; }
        public string? Deleted { get; set; }

    }
}
