using Delegate_homework.Services;
using Delegate_homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_homework.Controllers
{
    internal class BookController
    {
        private readonly IBookService _bookService;

        public BookController()
        {
            _bookService =new BookService();
        }
        public void FindBookAutor()
        {
            var response = _bookService.FindBookAutor(m => m.Author.Contains("Nizami"));
            foreach (var item in response)
            {
                Console.WriteLine(item.Name + "-" + item.Author);
            }
        }

    }
}
