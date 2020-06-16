using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoBookstore.Pages
{
    public class BooklistModel : PageModel
    { public IEnumerable<Book.info.Books> Book { get; set; }
        private readonly IData Data;
        public BooklistModel(IData data)
        {
            this.Data = data;
        }
            public void OnGet()
        {
            Book = Data.GetBooks;
        }
    }
}
