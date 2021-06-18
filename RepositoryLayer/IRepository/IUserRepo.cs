using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.IRepository
{
   public interface IUserRepo
    {
        User AddUserDetails(User user);
        bool Login(Login login);
    }
}
