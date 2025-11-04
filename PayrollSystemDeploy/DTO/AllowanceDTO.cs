namespace PayrollWebApp.DTO
{
    public class AllowanceDTO
    {
        public int AllowanceID { get; set; }
        public string? AllowanceName { get; set; }
        public decimal Percentage { get; set; }
        public string? Description { get; set; }
        public double? Amount {  get; set; }

        public bool? IncludeInForm16 { get; set; }  // BIT -> bool
        public string? Form16Section { get; set; }

        public string? IncludeInGross { get; set; }
        public string? AllowanceType { get; set; }

        public string? CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string? TrUser { get; set; }
        public DateTime? TrDate { get; set; }
        public string Deleted { get; set; } = "N";
    }
}
