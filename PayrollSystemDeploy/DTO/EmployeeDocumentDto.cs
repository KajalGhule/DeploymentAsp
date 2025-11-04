namespace PayrollWebApp.DTO
{
    public class EmployeeDocumentDto
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string FinancialYear { get; set; }
        public string SectionCode { get; set; }
        public string Purpose { get; set; }
        public double Amount { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentType { get; set; }
    }

}
