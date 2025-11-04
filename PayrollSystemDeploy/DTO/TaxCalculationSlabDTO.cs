namespace PayrollWebApp.DTO
{
    public class TaxCalculationSlabDTO
    {
        public int ID { get; set; }
        public decimal FromAmount { get; set; }
        public decimal ToAmount { get; set; }
        public decimal Percentage { get; set; }
        public string FinancialYear { get; set; }  // Format: "20252026"
    }

}
