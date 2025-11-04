namespace PayrollWebApp.DTO
{
    public class UserRightDTO
    {
        public string FormName { get; set; }
        public bool CanView { get; set; }
        public bool CanAdd { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
    }
}
