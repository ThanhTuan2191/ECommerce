using ECom.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Service
{
    public class LoginService
    {
        ECommerceDataContext eCommerceDataContext = new ECommerceDataContext();
        public bool Login(string email, string password)
        {
            var ok = eCommerceDataContext.AppUsers.FirstOrDefault(x => x.Email.Equals(email)
            && x.Password.Equals(password));
            if(ok != null)
            {
                return true;
            }
            return false;
        }
    }
}
