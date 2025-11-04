namespace PayrollWebApp.DTO
{
    public class EmployeeExcelUploadDTO
    {
        public int SrNo { get; set; }
        public string DesignationName { get; set; }
        public string DepartmentName { get; set; }
        public string EducationName { get; set; }
        public string GradeName { get; set; }
        public string SectionName { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NameOnAadharCard { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string WhatsAppNumber { get; set; }
        public string EmailId { get; set; }
        public string AadharCardNumber { get; set; }
        public string PANNumber { get; set; }
        public string DrivingLicNo { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? JoiningDate { get; set; }
        public double GrossSalary { get; set; }
        public string BankAccountNo { get; set; }
        public string IFSCCode { get; set; }
        public string PFAccountNo { get; set; }
        public string UANNumber { get; set; }
        public string ESICNumber { get; set; }
        public string GratuityNumber { get; set; }
        public string MLWFLinNumber { get; set; }

        public string CalculatePT { get; set; }
        public string CalculatePF { get; set; }
        public string HRACalculation { get; set; }
        public string CalculateESIC { get; set; }

        public string CrUser { get; set; }
        public DateTime CrDate { get; set; }
        public string Deleted { get; set; } = "N";
    }
}
