using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthThirdParty.DAL
{
    public class Repository
    {
        static List<User> _Users = new List<User>
        {
            new User { Email = "user@test.com", Password= "testUser", Roles = "Editor" },
            new User { Email = "admin@test.com", Password = "adminUser", Roles = "Admin, Editor" }
        };

        public static User GetUserDetails(User user)
        {
            return _Users.Where(u => u.Email.Equals(user.Email) && u.Password.Equals(user.Password))
                .FirstOrDefault();
        }
    }
}