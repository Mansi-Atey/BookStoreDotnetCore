using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerLayer.IManager
{
   public interface IUserManager
    {
        User AddUserDetails(User user);
        bool Login(Login login);
    }
}
