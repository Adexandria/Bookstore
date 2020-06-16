using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoBookstore.Pages
{
    public class PopularModel : PageModel
    { 
        public IEnumerable<Book.info.Books> Books { get; set; }
        private readonly IData data;
       
        public PopularModel(IData data)
        {
            this.data = data;
        }
        public void OnGet()
        {
            Books = data.TrendyBooks;
            
        }
    }
}
