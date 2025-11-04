namespace PayrollWebApp.DTO
{
    public class Form16AllowanceDto
    {
        public int AllowanceID { get; set; }
        public string? AllowanceName { get; set; }
        public bool IncludeInForm16 { get; set; }
        public string? Form16Section { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
