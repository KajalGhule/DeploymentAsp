namespace PayrollWebApp.DTO
{
    public class DeductionDTO
    {
        public int DeductionID { get; set; }
        public string DeductionName { get; set; }
        public decimal Percentage { get; set; }
        public string? Description { get; set; }
        public double? Amount { get; set; }
        public string? CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string? TrUser { get; set; }
        public DateTime? TrDate { get; set; }
        public string Deleted { get; set; } = "N";
    }
}
