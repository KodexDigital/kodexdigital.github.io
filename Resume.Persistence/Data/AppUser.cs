using System;
using System.ComponentModel.DataAnnotations;

namespace Resume.Persistence.Data
{
    public class AppUser
    {
        [Key]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordKey { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
