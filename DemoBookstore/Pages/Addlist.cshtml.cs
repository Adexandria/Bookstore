using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoBookstore.Pages
{
    public class AddlistModel : PageModel
    {
        [BindProperty]
        public Book.info.Books Books { get; set; }
        [BindProperty]

        public Book.info.Details Details { get; set; }
        readonly IDetails data;
        readonly IData data1;
        public AddlistModel(IDetails data,IData data1)
        {
            this.data = data;
            this.data1 = data1;
        }
        public IActionResult OnGet(int id)
        {
            Books = data1.GetId(id);
            Details = new Book.info.Details();
                
            
            
            return Page();
        }
        public IActionResult OnPost()
        { 
            
            data.Add(Details);
                data.Commit();
                return RedirectToPage("./Booklist",new {id =Details.Id });
          
            
        }
    }
}
