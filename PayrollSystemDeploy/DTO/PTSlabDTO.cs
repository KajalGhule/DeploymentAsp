namespace PayrollWebApp.DTO
{
    public class PTSlabDTO
    {
        public int PTSlabID { get; set; }
        public int PTID { get; set; }
        public float FromAmount { get; set; }
        public float ToAmount { get; set; }
        public float Amount { get; set; }

        public string? CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string? TrUser { get; set; }
        public DateTime? TrDate { get; set; }
        public string Deleted { get; set; } = "N";
    }

}
