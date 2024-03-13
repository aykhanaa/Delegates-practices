using Delegate_homework.Data;
using Delegate_homework.Models;
using Delegate_homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_homework.Services
{
    internal class BookService : IBookService
    {
        public List<Book> FindBookAutor(Predicate<Book> predicate)
        {
            List<Book> findbookautor = new List<Book>();
            foreach (var item in AppDbContext.books)
            {
                if (predicate(item))
                {
                    findbookautor.Add(item);
                }
            }
            return findbookautor;
        }
    }
    
}
