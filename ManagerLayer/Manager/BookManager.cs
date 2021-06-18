using ManagerLayer.IManager;
using ModelLayer;
using RepositoryLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerLayer
{
   public class BookManager : IBookManager
    {
        private readonly IBookRepo bookRepository;

        public BookManager(IBookRepo bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public List<Books> GetAllBooks()
        {
            return this.bookRepository.GetAllBooks();
        }
    }
}
