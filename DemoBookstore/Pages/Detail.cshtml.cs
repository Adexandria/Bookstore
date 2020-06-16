using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoBookstore.Pages
{
    public class DetailModel : PageModel
    {
       
        private readonly IData data;
       
        public IEnumerable<Books.Data.Books> Books { get; set; }
        public DetailModel(IData data)
        {
            this.data = data;
        }

        public void OnGet()
        {
            Books = data.Newbooks;
        }
    }
}
