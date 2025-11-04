namespace PayrollWebApp.DTO
{
    public class UploadDocumentDto
    {
        public string EmployeeCode { get; set; }
        public string FinancialYear { get; set; }
        public string SectionCode { get; set; }
        public string Purpose { get; set; }
        public double Amount { get; set; }
        public IFormFile File { get; set; }

        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string Deleted { get; set; } = "N";
    }
}
