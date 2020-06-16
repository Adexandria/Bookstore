using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoBookstore.Pages
{
    public class MoreModel : PageModel
    {
        [BindProperty]
        public Book.info.Books Books { get; set; }
        private readonly IData data;
        public MoreModel(IData data)
        {
            this.data = data;
        }
        public IActionResult OnGet()
        {
            Books = new Book.info.Books();
            return Page();
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                data.Add(Books);
            data.Commit();
            return RedirectToPage("./Addlist",new { id=Books.Id});
                
            }
           return Page();
        }
    }
}
