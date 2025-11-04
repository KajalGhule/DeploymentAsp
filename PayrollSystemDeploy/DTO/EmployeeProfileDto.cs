namespace PayrollWebApp.DTO
{
    public class EmployeeProfileDto
    {
        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }

        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string NameOnAadharCard { get; set; }

        public string Gender { get; set; }
        public string FatherHusbandName { get; set; }

        public DateTime? BirthDate { get; set; }

        public string EmailId { get; set; }

        public string PermanentAddress { get; set; }

        public string PANNo { get; set; }
        public string AadharCardNumber { get; set; }

        public string BankAccountNo { get; set; }
        public string IFSCCode { get; set; }

        public DateTime? JoiningDate { get; set; }

        public string PFAccountNo { get; set; }
        public string ESICNo { get; set; }

        public string DepartmentName { get; set; }

        public string DesignationName { get; set; }

        public string GradeName { get; set; }

        public string SectionName { get; set; }
    }

}
