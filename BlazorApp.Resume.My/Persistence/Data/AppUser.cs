using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Resume.My.Persistence.Data
{
    public class AppUser //: IdentityUser
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PasswordKey { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
