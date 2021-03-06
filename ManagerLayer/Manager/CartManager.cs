using ManagerLayer.IManager;
using ModelLayer;
using RepositoryLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerLayer.Manager
{
    public class CartManager : ICartManager
    {
        private readonly ICartRepo cartRepo;
        public CartManager(ICartRepo cartRepo)
        {
            this.cartRepo = cartRepo;
        }

        public List<CartResponse> GetAllCart()
        {
            return this.cartRepo.GetAllCart();
        }
    }
}
