namespace PayrollWebApp.DTO
{
    public class CancelLeaveRequestDto
    {
        public long LeaveAppID { get; set; }   // Leave Application ID
         // Who is cancelling
        public string EmployeeCode { get; set; }
        public string TrUser { get; set; }     // Employee username
    }
}
