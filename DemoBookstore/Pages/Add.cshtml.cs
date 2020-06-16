using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoBookstore.Pages
{
    public class AddModel : PageModel
    {
        public Book.info.Books Details { get; set; }
        public Book.info.Details Data { get; set; }
        private readonly IData data;
        private readonly IDetails info;
        public AddModel(IData data,IDetails info)
        {
            this.data = data;
        }

        public IActionResult OnGet(int id)
        {
            Details = data.GetId(id);
            if(Data != null)
            {
               Data = info.GetDetails(id);
            }
            
            return Page();

        }
        public IActionResult OnPost(int id)
        {
            Details = data.Delete(id);
            if( Data != null)
            {
               Data = info.Delete(id);
            }
            
            data.Commit();
            if(Details == null)
            {
                return RedirectToPage("./Notfound");
            }
            TempData["Message"] = $"{Details.Name} deleted";
            return RedirectToPage("./Booklist");
        }
    }
}
