using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoBookstore.Pages
{
    public class ListModel : PageModel
    {
        private readonly IDetails data;
        private readonly IData data1;
        public Details Books { get; set; }
        public Books.Data.Books Paper { get; set; }
        public ListModel(IDetails data, IData data1)
        {
            this.data = data;
            this.data1 = data1;
        }
        public IActionResult OnGet(int id)
        {
            Books = data.GetDetails(id);
            Paper = data1.GetId(id);
            if(Books == null)
            {
                return RedirectToPage("./Addlist");
            }
            if (Paper == null)
            {
               return RedirectToPage("./Notfound");
            }
            return Page();
        }
    }
}
