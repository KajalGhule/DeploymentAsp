namespace PayrollWebApp.DTO
{
    public class DepartmentDTO
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string? DepartmentDescription { get; set; }
        public string? Incharge { get; set; }
        public string? CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string? TrUser { get; set; }
        public DateTime? TrDate { get; set; }
        public string Deleted { get; set; } = "N";
    }
}
