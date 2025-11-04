namespace PayrollWebApp.DTO
{
    public class PTHeaderDTO
    {
        public int PTID { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public List<PTSlabDTO> SlabDetails { get; set; } = new();

        public string? CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string? TrUser { get; set; }
        public DateTime? TrDate { get; set; }
        public string Deleted { get; set; } = "N";
    }
}
