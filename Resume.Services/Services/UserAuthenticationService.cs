using Resume.Persistence.Data.Context;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Resume.My.Services
{
    public class UserAuthenticationService
    {
        private readonly KEODbContext dbContext;
        private string UserName = null;
        private readonly DateTime dd = DateTime.Now;
        private int CurrenDay = 0;
        public UserAuthenticationService(KEODbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private string AuthUsernameToken(string username)
        {
            CurrenDay = dd.Day;
            var cracker = CurrenDay.ToString() + dd.Year.ToString();
            var fromDb = dbContext.Users.FirstOrDefault(u => u.Username.Equals(username));
            if(fromDb != null)
            {
                UserName = $"{fromDb.Username}{cracker}";
                return UserName;
            }
            
            return string.Empty;
        }

        public async Task<string> Login(string username)
        {
            return username;
        }

        //public async Task<AppUser> Login(string username)
        //{
        //    if (!string.IsNullOrEmpty(username))
        //    {
        //        //if (!string.IsNullOrEmpty(AuthUsernameToken(username)))
        //        //{

        //        //}

        //        var user = dbContext.Users.FirstOrDefault(u => u.Username.Equals(username));
        //        return user;
        //    }
        //    return 
        //}
    }
}
