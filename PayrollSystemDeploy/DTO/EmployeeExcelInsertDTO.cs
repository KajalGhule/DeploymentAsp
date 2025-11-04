namespace PayrollWebApp.DTO
{
    public class EmployeeExcelInsertDTO
    {
         public string EmployeeCode { get; set; }
         public int DesignationID { get; set; }
         public int DepartmentID { get; set; }
         public int EducationID { get; set; }
         public int GradeId { get; set; }
         public int SectionID { get; set; }
         public string FName { get; set; }
         public string? MName { get; set; }
         public string LName { get; set; }
         public string NameOnAadharCard { get; set; }
         public string Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public DateTime? BirthDate { get; set; }
        public int Age { get; set; }
        public string BloodGroup { get; set; }
         public string EmpPassword { get; set; }
         public string PermanentAddress { get; set; }
         public string PresentAddress { get; set; }
        public string? Country { get; set; }
        public string State { get; set; }
        public string? District { get; set; }
        public string? Taluka { get; set; }
        public string City { get; set; }
         public string Pincode { get; set; }
         public string PhoneNo1 { get; set; }
         public string PhoneNo2 { get; set; }
         public string EmailId { get; set; }
         public string AadharCardNumber { get; set; }
         public string PANNo { get; set; }
         public string DrivingLicNo { get; set; }
         public string PassportNo { get; set; }

         public DateTime? JoiningDate { get; set; }
        public DateTime? RetirementDate { get; set; }
        public string EmployeeType { get; set; }

        public DateTime? ExitDate { get; set; }
        public DateTime? ReJoiningDate { get; set; }
        public string? PreviousExperience { get; set; }

         public string CalculatePT { get; set; }
         public string CalculatePF { get; set; }
         public string HRACalculation { get; set; }
         public string CalculateESIC { get; set; }
         public string BankAccountNo { get; set; }
         public string IFSCCode { get; set; }
         public string PFAccountNo { get; set; }
         public string UANNo { get; set; }
         public string ESICNo { get; set; }
         public string GratuityNo { get; set; }
         public string MLWFLinNo { get; set; }

        public double? GrossSalary { get; set; }
        public double? BasicSalary { get; set; }
         public double? PerDaySalary { get; set; }
         public double? TotalAllow { get; set; }
         public double? TotalDeduction { get; set; }
         public double? NetSalary { get; set; }

        // Family Details
         public string FatherHusbandName { get; set; }
         public DateTime? FatherHusbandDOB { get; set; }
         public string FatherHusbandRelation { get; set; }
         public string MotherWifeName { get; set; }
         public DateTime? MotherWifeDOB { get; set; }
         public string MotherWifeRelation { get; set; }
         public string Child1Name { get; set; }
         public string Child1Gender { get; set; }
         public DateTime? Child1DOB { get; set; }
         public string Child2Name { get; set; }
         public string Child2Gender { get; set; }
         public DateTime? Child2DOB { get; set; }

        public EmployeeAllowanceDTO? Allowances { get; set; } = new EmployeeAllowanceDTO();
        public EmployeeDeductionDTO? Deductions { get; set; } = new EmployeeDeductionDTO();



        public string CrUser { get; set; }
        public DateTime CrDate { get; set; }
        public string? TrUser { get; set; }
        public DateTime? TrDate { get; set; }
        public string Deleted { get; set; } = "N";
    }
}
