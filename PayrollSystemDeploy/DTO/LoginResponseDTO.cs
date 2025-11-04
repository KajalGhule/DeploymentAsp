namespace PayrollWebApp.DTO
{
    public class LoginResponseDTO
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string Username { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; } // ClientAddress , EmailID
        public string UserRoll {  get; set; }
                                            // Add this for rights
        public List<UserRightDTO> UserRights { get; set; }

        public int UserID { get; set; }
    }
}
