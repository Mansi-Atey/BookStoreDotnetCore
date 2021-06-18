using ModelLayer;
using RepositoryLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerLayer.Manager
{
   public class WishListManager
    {
        private readonly IWishListRepo wishListRepository;

        public WishListManager(IWishListRepo wishListRepository)
        {
            this.wishListRepository = wishListRepository;
        }
        public List<ResponseWishlist> ViewWishListDetails()
        {
            return this.wishListRepository.ViewWishListDetails();
        }
    }
}
