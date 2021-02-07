using System;

namespace Fortnite.Net.Model.Account
{
    public class XGameProfile
    {
        
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int FailedLoginAttempts { get; set; }
        public DateTime LastFailedLogin { get; set; }
        public DateTime LastLogin { get; set; }
        public int NumberOfDisplayNameChanged { get; set; }
        public string AgeGroup { get; set; }
        public bool Headless { get; set; }
        public string Country { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        
    }
}