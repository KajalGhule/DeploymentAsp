namespace PayrollWebApp.DTO
{
    public class SalaryProcessRequestDTO
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int? DeptID { get; set; }
        public int? SectionID { get; set; }
        public string CrUser { get; set; }
        public DateTime CrDate { get; set; }
    }

}
