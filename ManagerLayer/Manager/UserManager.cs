using ManagerLayer.IManager;
using ModelLayer;
using RepositoryLayer.IRepository;
using System;

namespace ManagerLayer
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepo userRepository;
        public UserManager(IUserRepo userRepository)
        {
            this.userRepository = userRepository;
        }
        public User AddUserDetails(User users)
        {
            return this.userRepository.AddUserDetails(users);
        }
        public bool Login(Login login)
        {
            return this.userRepository.Login(login);
        }
    }
}
