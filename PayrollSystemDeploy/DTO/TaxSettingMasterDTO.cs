namespace PayrollWebApp.DTO
{
    public class TaxSettingMasterDTO
    {
        public int ID { get; set; }
        public string SettingName { get; set; }    // e.g., "EducationCessPercent"
        public decimal SettingValue { get; set; }  // e.g., 3.00
        public string FinancialYear { get; set; }  // Format: "2025-26"
    }

}
