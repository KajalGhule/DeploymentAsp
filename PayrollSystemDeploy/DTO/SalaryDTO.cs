namespace PayrollWebApp.DTO
{
    public class SalaryDTO
    {
        public int SalaryID { get; set; }
        public string EmployeeName { get; set; }  // From EmployeeMaster
        //public int DepartmentID { get; set; }
        //public int SectionID { get; set; }
        //public int SalaryMonth { get; set; }
        //public int SalaryYear { get; set; }

        public decimal Allowance1 { get; set; }
        public decimal Allowance2 { get; set; }
        public decimal Allowance3 { get; set; }
        public decimal Allowance4 { get; set; }
        public decimal Allowance5 { get; set; }
        public decimal Allowance6 { get; set; }
        public decimal Allowance7 { get; set; }
        public decimal Allowance8 { get; set; }
        public decimal Allowance9 { get; set; }
        public decimal Allowance10 { get; set; }
        public decimal Allowance11 { get; set; }
        public decimal Allowance12 { get; set; }
        public decimal Allowance13 { get; set; }
        public decimal Allowance14 { get; set; }
        public decimal Allowance15 { get; set; }

        public decimal TotalAllowance { get; set; }

        public decimal Deduction1 { get; set; }
        public decimal Deduction2 { get; set; }
        public decimal Deduction3 { get; set; }
        public decimal Deduction4 { get; set; }
        public decimal Deduction5 { get; set; }
        public decimal Deduction6 { get; set; }
        public decimal Deduction7 { get; set; }
        public decimal Deduction8 { get; set; }
        public decimal Deduction9 { get; set; }
        public decimal Deduction10 { get; set; }
        public decimal Deduction11 { get; set; }
        public decimal Deduction12 { get; set; }
        public decimal Deduction13 { get; set; }
        public decimal Deduction14 { get; set; }
        public decimal Deduction15 { get; set; }

        public decimal TotalDeduction { get; set; }
        public decimal NetSalary { get; set; }
    }

}
