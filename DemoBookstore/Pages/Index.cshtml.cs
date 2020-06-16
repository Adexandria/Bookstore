using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DemoBookstore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IData data;
        public IEnumerable<Books.Data.Books> Books { get; set; }
        public IndexModel(ILogger<IndexModel> logger,IData data)
        {
            _logger = logger;
            this.data = data;
        }

        public void OnGet()
        {
            Books = data.BookOftheweek;
        }
    }
}
