using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.IRepository
{
   public interface IBookRepo
    {
        List<Books> GetAllBooks();
    }
}
