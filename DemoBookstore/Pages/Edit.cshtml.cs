using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoBookstore.Pages
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Books.Data.Books Books { get; set; }
        private readonly IData data;
        [BindProperty]
        public Details Details {get; set;}
        private readonly IDetails data1;
        public EditModel(IData data, IDetails data1)
        {
            this.data = data;
            this.data1 = data1;
        }
        public IActionResult OnGet(int? id)
        {
            if(id.HasValue)
            {
                Books = data.GetId(id.Value);
                Details = data1.GetDetails(id.Value);
            }
            else
            {
             Books = new Books.Data.Books();
            }
            if (Books == null)
            {
                return RedirectToPage("./Notfound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                data.Commit();
              data1.Commit();

                   data.Update(Books);
               
                TempData["Message"] = "Book Saved!";
                return RedirectToPage("./List", new { id = Books.Id });
            }

            return Page();
                
             
                
                
            
        }
    }
}
