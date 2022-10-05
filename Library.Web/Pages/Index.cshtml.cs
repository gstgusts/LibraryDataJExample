using Library.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Book> Books { get; set; } = Enumerable.Empty<Book>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var a = "";
        }

        public void OnPost()
        {
            var query = Request.Form["searchQuery"].ToString();

            Books = Program.Library.SearchByTitle(query);
        }
    }
}