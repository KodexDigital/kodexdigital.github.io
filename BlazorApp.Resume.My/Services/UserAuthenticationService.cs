using BlazorApp.Resume.My.Persistence.Data.Context;
using System;
using System.Linq;

namespace BlazorApp.Resume.My.Services
{
    public class UserAuthenticationService
    {
        private readonly KEODbContext dbContext;

        public UserAuthenticationService(KEODbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool IsUserLogin(string username, string passKey)
        {
            var fromDb = dbContext.Users.FirstOrDefault(u => u.UserName.Equals(username));
            var unHashPassKey = BCrypt.Net.BCrypt.Verify(passKey, fromDb.PasswordKey);
            if (fromDb != null && unHashPassKey) 
            {
                fromDb.LoginTime = DateTime.Now;
                dbContext.Users.Update(fromDb);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

    }

}
