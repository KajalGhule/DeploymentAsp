namespace PayrollWebApp.DTO
{
    public class EmployeeFamilyDTO
    {
        //public int EmployeeId { get; set; }
        public string? FatherHusbandName { get; set; }
        public DateTime? FatherHusbandDOB { get; set; }
        public string? FatherHusbandRelation { get; set; }

        public string? MotherWifeName { get; set; }
        public DateTime? MotherWifeDOB { get; set; }
        public string? MotherWifeRelation { get; set; }

        public string? Child1Name { get; set; }
        public DateTime? Child1DOB { get; set; }
        public string? Child1Gender { get; set; }

        public string? Child2Name { get; set; }
        public DateTime? Child2DOB { get; set; }
        public string? Child2Gender { get; set; }
    }
}
