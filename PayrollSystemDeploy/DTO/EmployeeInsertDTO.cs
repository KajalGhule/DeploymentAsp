namespace PayrollWebApp.DTO
{
    public class EmployeeInsertDTO
    {
        public int EmployeeID { get; set; }
        public string? EmployeeCode { get; set; }
        public long DesignationID { get; set; }
        public long DepartmentID { get; set; }
        public long EducationID { get; set; }
        public long GradeId { get; set; }
        public long SectionID { get; set; }

        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string NameOnAadharCard { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string BloodGroup { get; set; }
        public string EmpPassword { get; set; }

        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }
        public string Country { get; set; }
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

        public DateTime JoiningDate { get; set; }
        public DateTime? RetirementDate { get; set; }
        public string EmployeeType { get; set; }

        public string BankAccountNo { get; set; }
        public string IFSCCode { get; set; }
        public string PFAccountNo { get; set; }
        public string UANNo { get; set; }
        public string ESICNo { get; set; }
        public string GratuityNo { get; set; }
        public string MLWFLinNo { get; set; }

        public DateTime? ExitDate { get; set; }
        public DateTime? ReJoiningDate { get; set; }
        public string PreviousExperience { get; set; }
        public float? BasicSalary { get; set; }
        public float? PerDaySalary { get; set; }
        public float? GrossSalary { get; set; }
        public float? TotalAllow { get; set; }
        public float? TotalDeduction { get; set; }
        public float? NetSalary { get; set; }

        public string CalculatePT { get; set; }
        public string CalculatePF { get; set; }
        public string HRACalculation { get; set; }
        public string CalculateESIC { get; set; }

        public string CrUser { get; set; }
        public DateTime CrDate { get; set; }
        public string? TrUser { get; set; }
        public DateTime? TrDate { get; set; }
        public string Deleted { get; set; } = "N";

        public EmployeeAllowanceDTO Allowance { get; set; }
        public EmployeeDeductionDTO Deduction { get; set; }
        public EmployeeFamilyDTO FamilyDetails { get; set; }
    }
}
