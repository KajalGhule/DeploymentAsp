namespace PayrollWebApp.DTO
{
    public class SectionDTO
    {
        public int SectionID { get; set; }
        public string SectionName { get; set; }
        public int? DepartmentID { get; set; }
        public string? SectionDescription { get; set; }
        public string? DepartmentName { get; set; }
        public string? CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string? TrUser { get; set; }
        public DateTime? TrDate { get; set; }
        public string Deleted { get; set; } = "N";
    }
}
