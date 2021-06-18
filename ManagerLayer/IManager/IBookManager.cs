using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerLayer.IManager
{
    public interface IBookManager
    {
        List<Books> GetAllBooks();
    }
}
