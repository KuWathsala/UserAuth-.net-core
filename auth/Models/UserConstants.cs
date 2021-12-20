using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace auth.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel(){Username="jason_admin", EmailAddress="jason.admin@gmail.com", Password="1234@Abcd", GivenName="admin", Surname="r", Role="Admin"},
            new UserModel(){Username="jason_seller", EmailAddress="jason.seller@gmail.com", Password="5678@Efgh", GivenName="seller", Surname="r", Role="Admin"},
        };
    }
}
