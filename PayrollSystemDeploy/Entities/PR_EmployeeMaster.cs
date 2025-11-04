using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollWebApp.Entities
{
        [Table("PR_EmployeeMaster")]
        public class PR_EmployeeMaster
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public decimal EmployeeID { get; set; }

            [Required]
            [StringLength(50)]
            public string EmployeeCode { get; set; }

            public decimal DesignationID { get; set; }
            public decimal DepartmentID { get; set; }
            public decimal EducationID { get; set; }
            public decimal GradeId { get; set; }
            public decimal SectionID { get; set; }

            [Required]
            [StringLength(50)]
            public string FName { get; set; }

            [StringLength(50)]
            public string MName { get; set; }

            [Required]
            [StringLength(50)]
            public string LName { get; set; }

            [StringLength(100)]
            public string NameOnAadharCard { get; set; }

            [Required]
            [StringLength(10)]
            public string Gender { get; set; }

            [StringLength(20)]
            public string MaritalStatus { get; set; }

            [Required]
            public DateTime BirthDate { get; set; }

            public decimal Age { get; set; }

            [StringLength(5)]
            public string BloodGroup { get; set; }

            [StringLength(100)]
            public string EmpPassword { get; set; }

            [StringLength(255)]
            public string PermanentAddress { get; set; }

            [StringLength(255)]
            public string PresentAddress { get; set; }

            [StringLength(50)]
            public string Country { get; set; }

            [StringLength(50)]
            public string State { get; set; }

            [StringLength(50)]
            public string District { get; set; }

            [StringLength(50)]
            public string Taluka { get; set; }

            [StringLength(50)]
            public string City { get; set; }

            [StringLength(10)]
            public string Pincode { get; set; }

            [StringLength(10)]
            public string PhoneNo1 { get; set; }

            [StringLength(10)]
            public string PhoneNo2 { get; set; }

            [StringLength(100)]
            public string EmailId { get; set; }

            [StringLength(20)]
            public string AadharCardNumber { get; set; }

            [StringLength(20)]
            public string PANNo { get; set; }

            [StringLength(30)]
            public string DrivingLicNo { get; set; }

            [StringLength(20)]
            public string PassportNo { get; set; }

            [Required]
            public DateTime JoiningDate { get; set; }

            public DateTime? RetirementDate { get; set; }

            [StringLength(50)]
            public string EmployeeType { get; set; }

            [StringLength(30)]
            public string BankAccountNo { get; set; }

            [StringLength(20)]
            public string IFSCCode { get; set; }

            [StringLength(30)]
            public string PFAccountNo { get; set; }

            [StringLength(30)]
            public string UANNo { get; set; }

            [StringLength(30)]
            public string ESICNo { get; set; }

            [StringLength(30)]
            public string GratuityNo { get; set; }

            [StringLength(30)]
            public string MLWFLinNo { get; set; }

            public DateTime? ExitDate { get; set; }
            public DateTime? ReJoiningDate { get; set; }

            [StringLength(100)]
            public string PreviousExperience { get; set; }

            public double? BasicSalary { get; set; }
            public double? PerDaySalary { get; set; }
            public double? GrossSalary { get; set; }
            public double? TotalAllow { get; set; }
            public double? TotalDeduction { get; set; }
            public double? NetSalary { get; set; }

            [StringLength(100)]
            public string CalculatePT { get; set; }

            [StringLength(100)]
            public string CalculatePF { get; set; }

            [StringLength(50)]
            public string HRACalculation { get; set; }

            [StringLength(100)]
            public string CalculateESIC { get; set; }

            [Required]
            [StringLength(50)]
            public string CrUser { get; set; }

            [Required]
            public DateTime CrDate { get; set; }

            [StringLength(50)]
            public string TrUser { get; set; }
            public DateTime? TrDate { get; set; }

            [Required]
            [Column(TypeName = "nchar(1)")]
            public string Deleted { get; set; }
        }
}
